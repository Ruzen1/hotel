using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
        {
            var timer = new System.Threading.Timer(ShowTime, null, 0, 1000);
        }
        private void ShowTime(object x)
        {
            // Don't do anything if the form's handle hasn't been created 
            // or the form has been disposed.
            if (!this.IsHandleCreated || this.IsDisposed) return;

            // Invoke an anonymous method on the thread of the form.
             this.Invoke((MethodInvoker)delegate
            {
                // Show the current time in the form's title bar.
                this.Text = DateTime.Now.ToLongTimeString();
            }) ;
        }
    }
}
