using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace CustomControls
{

    //control personalizado
    public class PersonTexBox : TextBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            if (PlaceHolder == "")
                PlaceHolder = "Nombre";
        }
        public bool change
        {
            get;
            set;
        }
        string placeHolder;
        public string PlaceHolder
        {
            get
            {
                return placeHolder;
            }
            set
            {
                placeHolder = value;
                this.Text = value;
                this.ForeColor = Color.Gray;
                change = false;

            }

        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.Text == placeHolder && this.Text != "")
            {
                change = false;

            }
            else
            {
                change = true;


            }
        }
        protected override void OnGotFocus(EventArgs e)
        {

            if (this.Text == placeHolder)
            {
                this.Text = "";
                this.ForeColor = Color.Black;


            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
             if (this.Text == "")
            {
            Renew();
            }
        }

        public void Renew()
        {

          
                this.Text = this.placeHolder;
                this.ForeColor = Color.Gray;
          
        }

    }
}
