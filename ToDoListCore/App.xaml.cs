using System;
using ToDoList.Data;
using Microsoft.Maui.Controls.Xaml;
using System.IO;
using ToDoList.Views;
using ToDoList.Data;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
namespace ToDoList
{
    public partial class App : Application
    {
        private static TodoItemDatabase database;
        internal static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase(Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.LocalApplicationData), "TodoListItems.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ToDoListPage());
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}