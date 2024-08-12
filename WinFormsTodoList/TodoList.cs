using System.ComponentModel;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsTodoList
{
    public partial class TodoList : Form
    {
        private readonly BindingList<string> _todos = new();
        public TodoList()
        {
            InitializeComponent();

            todosListBox.DataSource = _todos;
        }

        private void AddTodoWindow(object sender, EventArgs e)
        {
            MessageBox.Show("AddTodoWindow");
        }

        private void UpdateTodosWindow(object sender, EventArgs e)
        {
            MessageBox.Show("UpdateTodosWindow");
        }

        private void RemoveTodosWindow(object sender, EventArgs e)
        {
            MessageBox.Show("RemoveTodosWindow");
        }

        private void FilterTodosWindow(object sender, EventArgs e)
        {
            MessageBox.Show("FilterTodosWindow");
        }
    }
}