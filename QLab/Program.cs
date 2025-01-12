namespace QLab;
public class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Queue<int> q = new Queue<int>();
        q.Insert(7);
        q.Insert(10);
        q.Insert(3);
        Console.WriteLine(q);
        Queue<int> qCopy = SetQCopy(q);
        Console.WriteLine(q);
        Console.WriteLine(qCopy);
        q.Insert(17);
        qCopy.Insert(13);
        Console.WriteLine(q);
        Console.WriteLine(qCopy);
        int m = 3;
        bool IsMagicAnswer = IsMagic(qCopy, m);
        Console.WriteLine(IsMagicAnswer);

        
    }
        public static bool IsMagic(Queue<int> q, int m)
        {
        Queue<int> qCopy = SetQCopy(q);


        //יצרנו העתק של התור ועליו נפעיל את הבדיקה.
        // התור המקורי נשאר ללא שינוי
            bool isMagicNum = false;
            int num1;
            int num2;
            int count = 0;
            num1 = qCopy.Remove();
            count++;
            num2 = qCopy.Remove();
            count++;
            while (!qCopy.IsEmpty())
            {
               
                if (count == m)
                {
                    if (num2 == num1 + qCopy.Head())
                    {
                        return true;
                    
                    }
                    else
                    {
                    return false;
                }

                }
                else
                {
                    num1 = num2;
                    num2 = qCopy.Remove();
                    count++;
                    
            }
            }
            return isMagicNum;
        }
    

    public static Queue<int> SetQCopy(Queue<int> q)
    {
        Queue<int> qCopy = new();
        Queue<int> qTemp = new();            
        int currItem;
        //פריקת התור המקורי ויצירת תור העתק ותור זמני
        while (!q.IsEmpty())
        {
            currItem = q.Remove();
            qTemp.Insert(currItem);
            qCopy.Insert(currItem);
        }
        //שחזור התור המקורי
        while (!qTemp.IsEmpty())
        {
            q.Insert(qTemp.Remove());
        }
        return qCopy;
    }

    

}