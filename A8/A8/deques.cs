using System.Collections;
using System.Runtime.Intrinsics.X86;

public class MyQueue<T>:IEnumerable<T> , IConvertable<MyQueue<T>, MyStack<T>>
{
    public int Size { get; set; }
    public List<T> Values=new();
    public MyQueue()
    {
        Size=0;
        Values=new();}

    public void Enqueue(T obj)
{
        Size+=1;
        Values.Add(obj);}

    public T Dequeue()
    {
        Size-=1;
        T obj=Values[0];
        Values.RemoveAt(0);
        return obj;}

    public string Print()
    {
        string nums="";
        List<T> temp=new List<T>();
        for(int i=0;i<Size+3 ;i++)
        {
            temp.Add(Dequeue());}
        for(int j=0;j<temp.Count;j++)
        {
            Enqueue(temp[j]);
            nums+=temp[j];
            if(j!=temp.Count-1)
            nums+=" ";}
        return nums;}

    public IEnumerator<T> GetEnumerator()
    {
        for(int i=0;i<Size;i++)
            yield return Values[i];}

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();}

    public MyStack<T> Convert()
    {
        MyStack<T> stack=new MyStack<T>();
        for(int i=0;i<Values.Count;i++)
        {
            stack.Push(Values[i]);}
        return stack;}

    public static MyQueue<T> operator +(MyQueue<T> a, MyQueue<T> b)
    {
        MyQueue<T> result = new MyQueue<T>();

        foreach (T item in a.Values)
            result.Enqueue(item);

        foreach (T item in b.Values)
            result.Enqueue(item);

        return result;}

    public static MyQueue<T> operator +(MyQueue<T> a, MyStack<T> b)
    {
        MyQueue<T> result = new MyQueue<T>();

        foreach (T item in a.Values)
            result.Enqueue(item);

        for (int i = b.Values.Count - 1; i >= 0; i--)
            result.Enqueue(b.Values[i]);

        return result;}}

public interface IConvertable<TFrom, TTo>
{
    TTo Convert();}