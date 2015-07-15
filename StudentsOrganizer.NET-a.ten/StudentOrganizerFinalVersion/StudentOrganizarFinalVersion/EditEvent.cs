using StudentOrganizer.BO;
using StudentOrganizer.DBOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentOrganizarFinalVersion
{
    public partial class EditEvent : Form
    {
        Event event1;
        EventCommands eventComm;
        

        public EditEvent(Event event1)
        {
            InitializeComponent();
            this.event1 = event1;
            eventComm = new EventCommands(Properties.Settings.Default.connection);

            PeriodTextEdit.Text = event1.Period;
            DepartmentTextEdit.Text = event1.Department;
            TaskTextEdit.Text = event1.Task;
            RemarksTextEdit.Text = event1.Remarks;
            EventTypeTextEdit.Text = (event1.Event_Type_ID).ToString();

        }

        private void PeriodTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            event1.Period = PeriodTextEdit.Text;
            event1.Department = DepartmentTextEdit.Text;
            event1.Task = TaskTextEdit.Text;
            event1.Remarks = RemarksTextEdit.Text;
            event1.Event_Type_ID = Convert.ToInt32(EventTypeTextEdit.Text);

            eventComm.UpdateEvent(event1);

            PeriodTextEdit.Text = string.Empty;
            DepartmentTextEdit.Text = string.Empty;
            TaskTextEdit.Text = string.Empty;
            RemarksTextEdit.Text = string.Empty;
            EventTypeTextEdit.Text = string.Empty;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            List andrei = new List();
            andrei.Show();
            this.Hide();
        }
    }
}
