using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebUebung;

namespace API
{
    public partial class _Default : Page
    {
        Controller c = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_get_Click(object sender, EventArgs e)
        {
            TextBox res = txt_resultbox;
            c.UsePCApi("getPC", 0);
            res.Text = JsonConvert.SerializeObject(Global.PCs); 
        }

        protected void btn_post_Click(object sender, EventArgs e)
        {
            TextBox res = txt_resultbox;
            int id = Convert.ToInt32(txt_selection_id.Text);
            c.UsePCApi("postPC", id);
            res.Text = JsonConvert.SerializeObject(Global.PCs);
        }

        protected void btn_put_Click(object sender, EventArgs e)
        {
            TextBox res = txt_resultbox;
            int id = Convert.ToInt32(txt_selection_id.Text);
            string cpu = txt_cpu.Text;
            int ram = Convert.ToInt32(txt_ram.Text);
            c.UsePCApi("putPC", id, cpu, "Nvidia RTX 3070", ram, "ASRock B550 MB", "5000Watt Basemachine", 2000);
            res.Text = JsonConvert.SerializeObject(Global.PCs);
        }

        protected void btn_del_Click(object sender, EventArgs e)
        {
            TextBox res = txt_resultbox;
            int id = Convert.ToInt32(txt_selection_id.Text);
            c.UsePCApi("delPC", id);
            res.Text = JsonConvert.SerializeObject(Global.PCs);
        }

        protected void btn_dwnl_Click(object sender, EventArgs e)
        {
            string download = JsonConvert.SerializeObject(Global.PCs);
            Response.AddHeader("Content-disposition", String.Format($"attachment; filename=computers.json", "Metadata"));
            Response.ContentType = "application/json";
            Response.Write(download);
            Response.End();
        }
    }
}