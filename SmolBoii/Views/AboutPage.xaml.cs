using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmolBoii.Views
{
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
		}
		public int levelUpCounter = 0;
		public int tapCount = 0;
		public int medTapCount = 0;
		public int fedCount = 0;
		public bool justFed = false;
		public bool doneEating = false;
		private void OnTapCry(object sender, EventArgs e)
		{

			var imageSender = (Image)sender;

			// if you tap him too many times he gets sad!
			tapCount++;
			if (tapCount % 2 == 0)
			{
				imageSender.Source = "../Imgs/SmolBoi.png";

			}
			else if (doneEating == true)
			{
				imageSender.Source = "../Imgs/SmolHappyBoi.png";
				doneEating = false;

			}
			else if (fedCount % 3 == 0 && fedCount != 0)
			{
				imageSender.Source = "../Imgs/SmolBoiLookUp.png";
			}
			else if (levelUpCounter == 1)
			{
				imageSender.Source = "../Imgs/DoneGrowing.png";
				medTapCount++;
			}
			else if (levelUpCounter >= 1 && medTapCount > 35)
			{
				imageSender.Source = "../Imgs/MediumBoi.png";
			}
			else
			{
				imageSender.Source = "../Imgs/SmolSadBoi.png";
				tapCount--;
			}
			while (justFed == true)
			{
				imageSender.Source = "../Imgs/SmolBoiChew1.png";
				doneEating = true;
				justFed = false;
			}

		}
		private void OnTapFeed(object sender, EventArgs e)
		{
			var imageSender = (Image)sender;
			imageSender.TranslateTo(0, -100, 500);
			justFed = true;

			fedCount++;
			
			if (imageSender.TranslationY == -100)
			{
				imageSender.TranslateTo(0, 0, 500);
			}

		}

		private void OnTapBag(object sender, EventArgs e)
		{
			var imageSender = (Image)sender;
			if (fedCount % 3 == 0 && fedCount != 0)
			{
				imageSender.Source = "../Imgs/SerotoninCrumbs.png";
				levelUpCounter++;
				fedCount = 0;
			}	
			else
			{
				imageSender.Source = "../Imgs/PinkBag.png";
			}
		}
	}
}