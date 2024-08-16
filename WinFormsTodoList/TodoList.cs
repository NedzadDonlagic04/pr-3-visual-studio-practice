using System.ComponentModel;

namespace WinFormsTodoList
{
    public partial class TodoList : Form
    {
        private readonly BindingList<string> _todos = new();
        public TodoList()
        {
            InitializeComponent();

            // Random todos added for testing sake
            _todos.Add("Take out the trash");    
            _todos.Add("Learn how to cook chicken");    
            _todos.Add("Make dinner");    
            _todos.Add("Take a shower");    
            _todos.Add("Eat");    
        }   

        private void LoadForm(object sender, EventArgs e)
        {
            todosListBox.DataSource = _todos;
        }

        private static PromptInputForm CreateAddTodoForm() 
        {
            var addTodoForm = new PromptInputForm();

            addTodoForm.TextBoxWithLabel.LabelText = "Entere todo: ";
            addTodoForm.TextBoxWithLabel.MaxTextBoxInputLength = 30;
            addTodoForm.OkTodoButtonText = "Add";

            return addTodoForm;
        }

        private void AddTodoWindow(object sender, EventArgs e)
        {
            using var addTodoForm = CreateAddTodoForm();

            if (addTodoForm.ShowDialog() == DialogResult.OK) {
                string newTodo = addTodoForm.EnteredText.Trim();

                if (newTodo.Length > 0)
                {
                    _todos.Add(newTodo);
                }
            }
        }

        private void UpdateTodosWindow(object sender, EventArgs e)
        {
            using var updateTodoForm = new PromptInputForm();

            if (updateTodoForm.ShowDialog() == DialogResult.OK)
            {
                string newTodo = updateTodoForm.EnteredText.Trim();

                if (newTodo.Length > 0) {
                    _todos.Add(newTodo);
                }
            }
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