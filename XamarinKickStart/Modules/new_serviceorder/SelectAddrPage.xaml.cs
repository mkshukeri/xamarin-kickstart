using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinKickStart
{
	public partial class SelectAddrPage : ContentPage
	{
		public SelectAddrPage()
		{
			InitializeComponent();


			listAddressList.ItemsSource = new List<AddressInfo>{
				new AddressInfo{
					AddressName="Melur",
					AddressDetails="A-G04 Melur tbk 1/10",
					GPScoordinate="123,123"
				},
				new AddressInfo{
					AddressName="kampung",
					AddressDetails="10656 Jalan Haji Murshid",
					GPScoordinate="123,123"
				},
				new AddressInfo{
					AddressName="Office",
					AddressDetails="Tingkat 13 bangunan 2 sentral",
					GPScoordinate="113,123"
				},

			};
		}

		void Address_selected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			
		}
	}

	class AddressInfo
	{
		public string AddressName
		{
			get;
			set;
		}
		public string AddressDetails
		{
			get;
			set;
		}
		public string GPScoordinate
		{
			get;
			set;
		}
	}
}
