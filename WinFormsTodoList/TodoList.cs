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
            var addTodoForm = new PromptInputForm { Text = "Add Todo Form" };

            addTodoForm.Text = "Add Todo Form";
            addTodoForm.TextBoxWithLabel.LabelText = "Entere todo: ";
            addTodoForm.TextBoxWithLabel.MaxTextBoxInputLength = 30;
            addTodoForm.OkTodoButtonText = "Add";

            return addTodoForm;
        }

        private PromptInputForm CreateUpdateTodoForm(int todoIndex)
        {
            var updateTodoForm = new PromptInputForm { Text = "Update Todo Form" };

            updateTodoForm.TextBoxWithLabel.LabelText = "Update todo: ";
            updateTodoForm.TextBoxWithLabel.MaxTextBoxInputLength = 30;
            updateTodoForm.OkTodoButtonText = "Update";
            updateTodoForm.EnteredText = _todos[todoIndex];

            return updateTodoForm;
        }

        private void AddTodoWindow(object sender, EventArgs e)
        {
            using var addTodoForm = CreateAddTodoForm();

            if (addTodoForm.ShowDialog() == DialogResult.OK)
            {
                string newTodo = addTodoForm.EnteredText.Trim();

                if (newTodo.Length > 0)
                {
                    _todos.Add(newTodo);
                }
            }
        }

        private void UpdateTodosWindow(object sender, EventArgs e)
        {
            if (todosListBox.SelectedItems.Count != 1)
            {
                return;
            }

            int todoIndex = todosListBox.SelectedIndex;

            using var updateTodoForm = CreateUpdateTodoForm(todoIndex);

            if (updateTodoForm.ShowDialog() == DialogResult.OK)
            {
                _todos[todoIndex] = updateTodoForm.EnteredText;
            }
        }
        private List<string> GetSelectedItemsInList()
        {
            var selectedItems = new List<string>();
            foreach (var selectedItem in todosListBox.SelectedItems)
            {
                string? todo = selectedItem.ToString();

                if (todo != null)
                {
                    selectedItems.Add(todo);
                }
            }

            return selectedItems;
        }

        private void RemoveSelectedTodos(object sender, EventArgs e)
        {
            int selectedTodosCount = todosListBox.SelectedItems.Count;

            if (selectedTodosCount == 0)
            {
                return;
            }
            else if (selectedTodosCount > 1)
            {
                var removalConfirmation = MessageBox.Show(
                    "Do you wish to remove the selected todos?",
                    "Confirm Todo Removal",
                    MessageBoxButtons.YesNo
                );

                if (removalConfirmation != DialogResult.Yes)
                {
                    return;
                }
            }

            var selectedTodos = GetSelectedItemsInList();

            foreach (var todo in selectedTodos)
            {
                _todos.Remove(todo);
            }
        }
    }
}