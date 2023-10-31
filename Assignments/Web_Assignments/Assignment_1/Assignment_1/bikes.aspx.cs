using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class bikes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                ddlItems.Items.Add(new ListItem("BMW S 1000 RR", "bmw.png"));
                ddlItems.Items.Add(new ListItem("Ducati Panigale V4", "ducati.png"));
                ddlItems.Items.Add(new ListItem("Honda CBR 1000RR", "honda.png"));
                ddlItems.Items.Add(new ListItem("Yamaha YZF R1M", "yamaha.png"));
                ddlItems.Items.Add(new ListItem("Kawasaki Ninja H2", "kawasaki.png"));
            }

        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            string selectedImageUrl = ddlItems.SelectedItem.Value;
            BikeImg.ImageUrl = $"Images/{selectedImageUrl}";

        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            
            string selectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            lblCost.Text = $"Cost of {selectedItem}: {cost}";
        }

        
        private string GetItemCost(string item)
        {
         
            switch (item)
            {
                case "BMW S 1000 RR":
                    return "Rs 20,00,000";
                case "Ducati Panigale V4":
                    return "Rs 30,00,000";
                case "Honda CBR 1000RR":
                    return "Rs 45,00,000";
                case "Yamaha YZF R1M":
                    return "Rs 29,00,000";
                case "Kawasaki Ninja H2":
                    return "Rs 23,00,000";
                default:
                    return "N/A";
            }
        }
    }
}