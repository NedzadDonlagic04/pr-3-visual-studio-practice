namespace WinFormsTodoList
{
    public partial class TodoList : Form
    {
        public TodoList()
        {
            InitializeComponent();
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