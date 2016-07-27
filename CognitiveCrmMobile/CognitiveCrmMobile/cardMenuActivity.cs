using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CognitiveCrmMobile.Core.Model;
using CognitiveCrmMobile.Core.Service;

namespace CognitiveCrmMobile
{
    [Activity(Label = "Cards Menu", MainLauncher = true, Icon = "@drawable/crm_apps_icon_hi_contrast_32x32")]
    public class CardMenuActivity : Activity
    {
        private ListView cardMenuView;
        private List<Card> allCards;
        private CardsDataService cardDataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CardMenuView);
            cardMenuView = FindViewById<ListView>(Resource.Id.cardListView);
            cardDataService = new CardsDataService();
            allCards = cardDataService.GetAllCards();

            // Create your application here
        }
    }
}