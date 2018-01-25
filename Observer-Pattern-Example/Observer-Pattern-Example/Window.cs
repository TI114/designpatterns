using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Pattern_Example
{
    public partial class Window : Form, ObserverPattern.Observer
    {
        public Window()
        {
            InitializeComponent();
            //client testClient = new client();
            //testClient.Setstate(2);
            //testClient.test();

        }

        public void Update(int value)
        {
            value = value + 1;            
        }

        private void btn_add_observer_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_observer_Click(object sender, EventArgs e)
        {

        }

        private void btn_notify_observer_Click(object sender, EventArgs e)
        {

        }
    }
}
