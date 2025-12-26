class Paritate { 
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        bool ok = true;
        for (int i = 0; i < n; i++) {
            v[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n-1; i++) {
            if (v[i]%2 == v[i+1]%2) {
                Console.WriteLine("Doua elemente alaturate cu aceeasi paritate");
                ok = false;
            } 
        }
        if (ok) {
            Console.WriteLine("Nu exista doua elemente alaturate cu aceeasi paritate");
        }
    }
};