using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortAssistant
{
    class TextBoxBuffer
    {
        /// <summary>
        /// size of buffer in bytes
        /// </summary>
        private int size;
        /// <summary>
        /// buffer array
        /// </summary>
        private char[] buffer;
        /// <summary>
        /// constructor, setting the size of text buffer
        /// </summary>
        /// <param name="size"></param>
        public TextBoxBuffer(int size)
        {
            this.size = size;
            buffer = new char[this.size];
        }
    }
}
