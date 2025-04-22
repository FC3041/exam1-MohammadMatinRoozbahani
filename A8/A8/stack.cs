using System.Collections;

public class MyStack<T>:IEnumerable<T> , IConvertable<MyStack<T>, MyQueue<T>>
{
    public int Size { get; set; }
    public List<T> Values { get; set; }

    public MyStack()
    {
        Size=0;
        Values= new();}

    public void Push(T obj)
    {
        Size+=1;
        Values.Add(obj);}

    public T Pop()
    {
        Size-=1;
        T obj=Values[Values.Count-1];
        Values.RemoveAt(Values.Count-1);
        return obj;}

    public string Print()
    {
        string nums = "";
        List<T> temp = new List<T>();

        for (int i = 0; i < Size+3; i++)
        {
            temp.Add(Pop());}
        for(int j=0;j<temp.Count;j++)
        {
            Push(temp[j]);
            nums+=temp[j].ToString();
            if(j!=temp.Count-1)
            nums+=" ";
        }
        return nums;}

    public IEnumerator<T> GetEnumerator()
    {
        for(int i=1;i<Values.Count;i++)
        {
            yield return Values[Size - i];}}

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)Values).GetEnumerator();}

    public MyQueue<T> Convert()
    {
        MyQueue<T> queue=new MyQueue<T>();
        for(int i=1;i<Values.Count;i++)
        {
            queue.Enqueue(Values[Values.Count-i]);}
        return queue;}

    public static MyStack<T> operator +(MyStack<T> a, MyStack<T> b)
    {
        MyStack<T> result = new MyStack<T>();

        foreach (T item in a.Values)
            result.Push(item);

        for (int i = b.Values.Count - 1; i >= 0; i--)
            result.Push(b.Values[i]);

        return result;}
    public static MyStack<T> operator +(MyStack<T> a, MyQueue<T> b)
    {
        MyStack<T> result = new MyStack<T>();

        foreach (T item in a.Values)
            result.Push(item);

        for (int i = 0; i < b.Values.Count; i++)
            result.Push(b.Values[i]);

        return result;}}