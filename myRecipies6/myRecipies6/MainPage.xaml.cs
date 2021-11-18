using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using myRecipies6;
using Todo.Views;

namespace myRecipies6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //just have to make this page redirect to the todopage then test that then redo the code to fit assignment
            InitializeComponent();
            App.Current.MainPage = new NavigationPage(new Todo.Views.TodoListPage());

        }
        
    }
}
