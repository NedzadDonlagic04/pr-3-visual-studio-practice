using System.ComponentModel;

namespace WinFormsTodoList
{
    public partial class TodoList : Form
    {
        private readonly BindingList<string> _todos = new();
        public TodoList()
        {
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            todosListBox.DataSource = _todos;
        }

        private void AddTodoWindow(object sender, EventArgs e)
        {
            using var addTodoForm = new AddTodoForm();

            if (addTodoForm.ShowDialog() == DialogResult.OK) {
                string newTodo = addTodoForm.EnteredTodo;
                _todos.Add(newTodo);
            }
        }

        private void UpdateTodosWindow(object sender, EventArgs e)
        {
            MessageBox.Show("UpdateTodosWindow");
        }

        private void RemoveTodosWindow(object sender, EventArgs e)
        {
            if (_todos.Count > 0)
            {
                _todos.RemoveAt(0);
            }
        }

        private void FilterTodosWindow(object sender, EventArgs e)
        {
            MessageBox.Show("FilterTodosWindow");
        }
    }
}