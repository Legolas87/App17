using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App17.Services;
using App17.Views;

namespace App17
{
  public partial class App : Application
  {

    public App()
    {
      InitializeComponent();

      DependencyService.Register<MockDataStore>();
      MainPage = new MainPage();
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
