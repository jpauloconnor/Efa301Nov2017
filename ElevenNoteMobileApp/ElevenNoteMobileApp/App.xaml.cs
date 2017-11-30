﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElevenNoteMobileApp.Contracts;
using ElevenNoteMobileApp.Services;
using Xamarin.Forms;

// Define dependencies for injection.
[assembly: Xamarin.Forms.Dependency(typeof(FakeNoteService))]
namespace ElevenNoteMobileApp
{
	public partial class App : Application
	{
	    public static readonly INoteService NoteService = DependencyService.Get<INoteService>();

		public App ()
		{
			InitializeComponent();

			MainPage = new ElevenNoteMobileApp.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
