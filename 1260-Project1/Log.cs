using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class Log : IDisposable
    {
        private StreamWriter writer;
        private string path;
        private int count;
        private bool isClosed;

        public string Path { get { return path; } }
        public int Count { get { return count; } }
        public bool IsClosed { get { return isClosed; } }

        public Log(string path)
        {
            writer = new StreamWriter(path);

            writer.WriteLine("LOG OPENED");
            count = 0;
            isClosed = false;
        }


        public void Dispose()
        {
            if (isClosed == true)
            {
                return;
            }
            try
            {
                if (writer != null)
                {
                    writer.Close();

                }
            }
            catch
            {

            }
            finally
            {
                writer = null;
                isClosed = true;
            }

        }
    }
}
