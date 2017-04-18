using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinKickStart
{
	public partial class ServiceListPage : ContentPage
	{
		public ServiceListPage()
		{
			InitializeComponent();

			listServiceList.ItemsSource = new List<ServiceInfo>{
				new ServiceInfo{
					ImageUrl="http://lorempixel.com/100/100/people/1",
					ServiceName="House Helper",
					ServiceDetails="Clean your home"
				},

				new ServiceInfo{
					ImageUrl="http://lorempixel.com/100/100/people/2",
					ServiceName="Handyman",
					ServiceDetails="Setup item in house"
				},

				new ServiceInfo{
					ImageUrl="http://lorempixel.com/100/100/people/3",
					ServiceName="Technician",
					ServiceDetails="Setup lights, CCTV etc"
				},
			};
		}
	}

	class ServiceInfo
	{
		public string ServiceName
		{
			get;
			set;
		}
		public string ImageUrl
		{
			get;
			set;
		}
		public string ServiceDetails
		{
			get;
			set;
		}
	}
}
