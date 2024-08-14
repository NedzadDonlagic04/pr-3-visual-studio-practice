using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTodoList
{
    public partial class AddTodoForm : Form
    {
        public string EnteredTodo { get; set; }
        public AddTodoForm()
        {
            InitializeComponent();
            EnteredTodo = "";
        }

        private void AddTodo(object sender, EventArgs e)
        {
            //EnteredTodo = enterTodoTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelAddingTodo(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EnteredTodoChange(object sender, EventArgs e)
        {

        }
    }
}
