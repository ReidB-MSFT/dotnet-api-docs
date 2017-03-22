    private static void PrintColumn(DataTableReader reader)
    {
        // Loop through all the rows in the DataTableReader
        while (reader.Read())
        {
            if (reader.IsDBNull(2))
            {
                Console.Write("<NULL>");
            }
            else
            {
                try
                {
                    Console.Write(reader.GetInt32(2));
                }
                catch (InvalidCastException)
                {
                    Console.Write("Invalid data type.");
                }
            }
            Console.WriteLine();
        }
    }