/**
 *  Default Namespaces
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ClinicManagementSystem
{
    class TimeHandler
    {
        /// <summary>
        /// Structure for managing system time
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        /// <summary>
        /// Set the system time
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME st);

        /// <summary>
        /// Get network time through ntp
        /// </summary>
        /// <returns></returns>
        public static DateTime GetNetworkTime()
        {
            //default Windows time server
            const string ntpServer = "ntp.pagasa.dost.gov.ph";

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.Connect(ipEndPoint);

            //Stops code hang if NTP is blocked
            socket.ReceiveTimeout = 3000;

            socket.Send(ntpData);
            socket.Receive(ntpData);
            socket.Close();

            //Offset to get to the "Transmit Timestamp" field (time at which the reply 
            //departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }

        /// <summary>
        /// Swap character encoding
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        /// <summary>
        /// Synchronize time with echo
        /// </summary>
        public static void SynchronizeTime()
        {
            DateTime dtntp = new DateTime();

            try
            {
                dtntp = TimeHandler.GetNetworkTime();
                SYSTEMTIME st = new SYSTEMTIME();
                st.wYear = Convert.ToInt16(dtntp.Year);
                st.wMonth = Convert.ToInt16(dtntp.Month);
                st.wDay = Convert.ToInt16(dtntp.Day);
                st.wHour = Convert.ToInt16(dtntp.Hour);
                st.wMinute = Convert.ToInt16(dtntp.Minute);
                st.wSecond = Convert.ToInt16(dtntp.Second);

                SetSystemTime(ref st);
                System.Windows.Forms.MessageBox.Show("Time has been synchronized!",
                                                        "Success!",
                                                        System.Windows.Forms.MessageBoxButtons.OK,
                                                        System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (System.Net.Sockets.SocketException)
            {
                System.Windows.Forms.MessageBox.Show("Cannot connect to the local time server!",
                                                        "Failed",
                                                        System.Windows.Forms.MessageBoxButtons.OK,
                                                        System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Synchronize time silently
        /// </summary>
        public static void SilentSynchronizeTime()
        {
            DateTime dtntp = new DateTime();

            try
            {
                dtntp = TimeHandler.GetNetworkTime();
                SYSTEMTIME st = new SYSTEMTIME();
                st.wYear = Convert.ToInt16(dtntp.Year);
                st.wMonth = Convert.ToInt16(dtntp.Month);
                st.wDay = Convert.ToInt16(dtntp.Day);
                st.wHour = Convert.ToInt16(dtntp.Hour);
                st.wMinute = Convert.ToInt16(dtntp.Minute);
                st.wSecond = Convert.ToInt16(dtntp.Second);

                SetSystemTime(ref st);
            }
            catch (System.Net.Sockets.SocketException)
            {
                // Do nothing
            }
        }

        /// <summary>
        /// Get Current date and time
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDateTime()
        {
            string current = "";

            current += DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.Hour + "" +
                DateTime.Now.Minute + "" + DateTime.Now.Second + "";

            return (current);
        }
    }
}
