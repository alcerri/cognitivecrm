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

namespace CognitiveCrmMobile.Adapters
{

    public class CardListAdapter: BaseAdapter<Card>
    {
        List<Card> items;
        Activity context;

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override Card this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public CardListAdapter(Activity context, List<Card> items): base()
        {
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return items[position].id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            if(convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(Android.Resource.Layout.)
            }
        }
    }
}