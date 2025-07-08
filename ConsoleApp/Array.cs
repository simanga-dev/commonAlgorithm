 class Array {

     int[] a { get; set; }

    public Array(int[] arry)
    {
        a = arry;
    }

    public void Print()
    {
        Console.WriteLine($"\nArray: {string.Join(" ", a)}\n");
    }

    public void Max()
    {
       int max = a[0];

       for (int i = 0; i < a.Length; i++)
           if (a[i] > max) max = a[i];

       Console.WriteLine($"Max Value: {max}\n");
    }

    public void Min()
    {
        int min = a[0];
        for (int i = 0; i < a.Length; i++)
            if(a[i] < min) min = a[i];

        Console.WriteLine($"Min Value: {min}\n");
    }

    public void Sort()
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                if(a[i] > a[j]) 
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }

}
