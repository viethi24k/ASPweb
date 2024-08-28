using System.Collections.Generic;

namespace MultiplicationTableApp.Services
{
    public class MultiplicationTableService
    {
        public List<MultiplicationRow> GetMultiplicationTable()
        {
            var table = new List<MultiplicationRow>();

            for (int i = 1; i <= 10; i++)
            {
                var row = new MultiplicationRow { Number = i };
                for (int j = 1; j <= 10; j++)
                {
                    row.Results.Add($"{i} x {j} = {i * j}");
                }
                table.Add(row);
            }

            return table;
        }
    }

    public class MultiplicationRow
    {
        public int Number { get; set; }
        public List<string> Results { get; set; } = new List<string>();
    }
}
