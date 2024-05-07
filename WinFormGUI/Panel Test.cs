using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System_Tentative
{
    public partial class Panel_Test : Form
    {
        public Panel_Test()
        {
            InitializeComponent();
        }

        private Panel AddDayWidget(Control parent, string dateName)
        {
            var panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.AutoSize = true;
            panel.Parent = parent;

            var date = new Label();
            date.Text = dateName;
            date.Font = new Font("Consolas", (float) 14.5, FontStyle.Regular);
            date.Parent = panel;
            date.AutoSize = true;
            date.TextAlign = ContentAlignment.MiddleCenter;
            date.Dock = DockStyle.Fill;

            int[] startingTime = { 8, 12, 13, 17, 19, 21 };

            for (int i = 0; i < 6; i++)
            {
                var dateTimePicker = createTimeSpanPicker(startingTime[i]);
                dateTimePicker.Parent = panel;
            }
            return panel;
        }


        private DateTimePicker createTimeSpanPicker(int startingTime)
        {
            var dateTimePicker = new DateTimePicker();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "hh:mm tt";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(120, 30);
            dateTimePicker.Font = new Font("Verdana", 14, FontStyle.Regular);
            dateTimePicker.Value = new DateTime(2000, 3, 21, startingTime, 0, 0);
            dateTimePicker.Margin = new Padding(10, 0, 10, 0);
            return dateTimePicker;
        }

        private void Panel_Test_Load(object sender, EventArgs e)
        {
            var mainPanel = new FlowLayoutPanel();
            mainPanel.FlowDirection = FlowDirection.TopDown;
            mainPanel.Parent = this;
            mainPanel.Size = new Size(1060, 260);
            mainPanel.WrapContents = false;
            mainPanel.AutoScroll = true;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Dock = DockStyle.Fill;

            var test = new Label();
            test.Parent = this;
            test.Text = "TESTING!";


            AddDayWidget(mainPanel, "05/02/2024 (THU)");
            AddDayWidget(mainPanel, "05/03/2024 (FRI)");
            AddDayWidget(mainPanel, "05/04/2024 (SAT)");
            AddDayWidget(mainPanel, "05/05/2024 (SUN)");
            AddDayWidget(mainPanel, "05/06/2024 (MON)");
            AddDayWidget(mainPanel, "05/07/2024 (TUE)");
            AddDayWidget(mainPanel, "05/08/2024 (WED)");
        }
    }
}
