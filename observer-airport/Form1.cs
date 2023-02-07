using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observer_airport
{
    public partial class Form1 : Form
    {
        public List<RichTextBox> flightLabels;
        private static int row_number = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            flightLabels = new List<RichTextBox> { flight_1, flight_2, flight_3, flight_4, flight_5, flight_6, flight_7, flight_8, flight_9, flight_10, flight_11, flight_12, flight_13, flight_14, flight_15, flight_16 };
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FlightInfo f = new FlightInfo();
            for (int i = 0; i < 30; i++)
            {
                f = new FlightInfo();
                PrintFlight(f);
            }
        }
        public void PrintFlight(FlightInfo f)
        {
            //============STAMPO LA LABEL====================
            flightLabels[row_number].Text = " " + f._time + "          " +
                                     f._from + "\t\t\t  " +
                                     f._to + "\t\t" +
                                     f._n + "\t" +
                                     f._gate;
            //===============================================
            row_number++;
            if (row_number > 15)
                row_number -= 16;
        }
    }
}
