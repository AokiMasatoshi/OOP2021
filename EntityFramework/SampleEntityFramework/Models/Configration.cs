using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models
{
    /*自動マイグレーション用*********/
    public  class Configration:DbMigrationsConfiguration<BooksDbContext>
    {
        public Configration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SampleEntityFrameWork.Models.BooksDbContext";
        }
    }
}
