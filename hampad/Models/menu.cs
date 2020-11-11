using System.Collections.Generic;
using DataLayer.AdminEntities.Category;
using DataLayer.AdminEntities.Logo;
using DataLayer.AdminEntities.SocialNetwork;
namespace hampad.Models
{
    public static class menu
    {
         public static List<Tb_Category> cat = new List<Tb_Category>();
         public static int resiver,sender,total_user,new_order,new_comment;
         public static string logo,Title,img;
         public static List<Tb_SocialNetwork> social = new List<Tb_SocialNetwork>();
         public static string Richat;
    }
}