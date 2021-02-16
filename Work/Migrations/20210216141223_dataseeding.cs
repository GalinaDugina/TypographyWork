using Microsoft.EntityFrameworkCore.Migrations;

namespace Work.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         migrationBuilder.InsertData(
                "Clients",
                new[] {"Id", "Name","TermsOfPayment","IsDelete"},
                new object[] {1, "Эфес Казахстан","30 дней",false}
            );
         migrationBuilder.InsertData(
             "Clients",
             new[] {"Id", "Name","TermsOfPayment","IsDelete"},
             new object[] {2, "Первый Пивзавод","30 дней",false}
         );
         migrationBuilder.InsertData(
             "Clients",
             new[] {"Id", "Name","TermsOfPayment","IsDelete"},
             new object[] {3, "Каспиан","30 дней",false}
         );
         migrationBuilder.InsertData(
             "Papers",
             new[] {"Id", "Name", "Height","Width","Density","PriceKZT","IsDelete"},
             new object[] {1, "этикеточная", 52,72,80,36,false}
         );
         migrationBuilder.InsertData(
             "Papers",
             new[] {"Id", "Name", "Height","Width","Density","PriceKZT","IsDelete"},
             new object[] {2, "металлизированная", 52,72,69,56,false}
         );
         migrationBuilder.InsertData(
             "Papers",
             new[] {"Id", "Name", "Height","Width","Density","PriceKZT","IsDelete"},
             new object[] {3, "металлизированная", 59,72,69,66,false}
         );
        }
        

        protected override void Down(MigrationBuilder migrationBuilder)
        {
 migrationBuilder.DeleteData(
                "Clients",
                new[] {"Id", "Name","TermsOfPayment","IsDelete"},
                new object[] {1, "Эфес Казахстан","30 дней",false}
            );
         migrationBuilder.DeleteData(
             "Clients",
             new[] {"Id", "Name","TermsOfPayment","IsDelete"},
             new object[] {2, "Первый Пивзавод","30 дней",false}
         );
         migrationBuilder.DeleteData(
             "Clients",
             new[] {"Id", "Name","TermsOfPayment","IsDelete"},
             new object[] {3, "Каспиан","30 дней",false}
         );
         migrationBuilder.DeleteData(
             "Papers",
             new[] {"Id", "Name", "Height","Width","Density","PriceKZT","IsDelete"},
             new object[] {1, "этикеточная", 52,72,80,36,false}
         );
         migrationBuilder.DeleteData(
             "Papers",
             new[] {"Id", "Name", "Height","Width","Density","PriceKZT","IsDelete"},
             new object[] {2, "металлизированная", 52,72,69,56,false}
         );
         migrationBuilder.DeleteData(
             "Papers",
             new[] {"Id", "Name", "Height","Width","Density","PriceKZT","IsDelete"},
             new object[] {3, "металлизированная", 59,72,69,66,false}
         );
        }
    }
}
