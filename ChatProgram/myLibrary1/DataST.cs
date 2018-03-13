using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;
namespace myLibrary1
{
    [Serializable()]
    public class DataST : ISerializable
    {

        private string textChat;
        private string name;
        private Font fontTextChat;
        private Color colorTextChat;
        private Color colorName;
        private Font fontName;

        public string TextChat
        {
            get
            {
                return textChat;
            }

            set
            {
                textChat = value;
            }
        }

        public Font FontTextChat
        {
            get
            {
                return fontTextChat;
            }

            set
            {
                fontTextChat = value;
            }
        }

        public Color ColorTextChat
        {
            get
            {
                return colorTextChat;
            }

            set
            {
                colorTextChat = value;
            }
        }

        public Color ColorName
        {
            get
            {
                return colorName;
            }

            set
            {
                colorName = value;
            }
        }

        public Font FontName
        {
            get
            {
                return fontName;
            }

            set
            {
                fontName = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DataST()
        {

            this.TextChat = "";

            this.FontTextChat = new Font("Arial", 9, FontStyle.Regular);
            this.ColorTextChat = Color.Red;
        }
        public DataST(string _textChat, Font _fontTextChat, Color _colorTextChat)
        {
            this.TextChat = _textChat;
            this.FontTextChat = _fontTextChat;
            this.ColorTextChat = _colorTextChat;
        }
        public DataST(DataST dt)
        {
            this.TextChat = dt.TextChat;
            this.FontTextChat = dt.FontTextChat;
            this.ColorTextChat = dt.ColorTextChat;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext strxt)
        {
            info.AddValue("_textChat", this.TextChat);
            info.AddValue("_fontTextChat", this.FontTextChat);
            info.AddValue("_colorTextChat", this.ColorTextChat);
        }
        public DataST(SerializationInfo info, StreamingContext strxt)
        {
            this.TextChat = (string)info.GetValue("_textChat", typeof(string));
            this.FontTextChat = (Font)info.GetValue("_fontTextChat", typeof(Font));
            this.ColorTextChat = (Color)info.GetValue("_colorTextChat", typeof(Color));
        }
    }
}

