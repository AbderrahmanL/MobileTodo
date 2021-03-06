﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TodoApp
{
    public partial class App : Application
    {
        public static TodoItemManager TodoManager { get; private set; }

        public static ITextToSpeech Speech { get; set; }

        public App()
        {
            TodoManager = new TodoItemManager(new RestService());
            MainPage = new NavigationPage(new TodoListPage());
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
