using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A8.Tests
{
    [TestClass]
    public class ConcatTests
    {
        [TestMethod]
        public void StackConvertTest()
        {
            MyStack<int> s = new MyStack<int>();
            s.Push(1);
            s.Push(4);
            s.Push(5);
            s.Push(2);
            MyQueue<int> q = s.Convert();
            Assert.AreEqual(q.Dequeue(), 2);
            Assert.AreEqual(q.Dequeue(), 5);
            Assert.AreEqual(s.Size, 4);
        }
       [TestMethod]
        public void QueueConvertTest()
        {
            MyQueue<int> q = new MyQueue<int>();
            q.Enqueue(1);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(2);
            MyStack<int> s = q.Convert();
            Assert.AreEqual(s.Pop(), 2);
            Assert.AreEqual(s.Pop(), 5);
            Assert.AreEqual(q.Size, 4);
        }
        [TestMethod]
        public void QueuePlusTest()
        {
            /* For queue + stack */
            MyQueue<int> q = new MyQueue<int>();
            q.Enqueue(1);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(2);

            MyStack<int> s = new MyStack<int>();
            s.Push(10);
            s.Push(40);
            s.Push(50);
            s.Push(20);

            q += s;

            Assert.AreEqual(q.Dequeue(), 1);
            Assert.AreEqual(q.Dequeue(), 4);
            Assert.AreEqual(q.Dequeue(), 5);
            Assert.AreEqual(q.Dequeue(), 2);
            Assert.AreEqual(q.Dequeue(), 20);
            Assert.AreEqual(q.Dequeue(), 50);
            Assert.AreEqual(q.Dequeue(), 40);
            Assert.AreEqual(q.Dequeue(), 10);

            /* For queue + queue */
            MyQueue<int> q1 = new MyQueue<int>();
            q1.Enqueue(1);
            q1.Enqueue(4);
            q1.Enqueue(5);
            q1.Enqueue(2);

            MyQueue<int> q2 = new MyQueue<int>();
            q2.Enqueue(10);
            q2.Enqueue(40);
            q2.Enqueue(50);
            q2.Enqueue(20);

            q1 += q2;

            Assert.AreEqual(q1.Dequeue(), 1);
            Assert.AreEqual(q1.Dequeue(), 4);
            Assert.AreEqual(q1.Dequeue(), 5);
            Assert.AreEqual(q1.Dequeue(), 2);
            Assert.AreEqual(q1.Dequeue(), 10);
            Assert.AreEqual(q1.Dequeue(), 40);
            Assert.AreEqual(q1.Dequeue(), 50);
            Assert.AreEqual(q1.Dequeue(), 20);
        }
        [TestMethod]
        public void StackPlusTest()
        {
            /* For stack + queue */
            // MyStack<int> s = new MyStack<int>();
            // s.Push(10);
            // s.Push(40);
            // s.Push(50);
            // s.Push(20);

            // MyQueue<int> q = new MyQueue<int>();
            // q.Enqueue(1);
            // q.Enqueue(4);
            // q.Enqueue(5);
            // q.Enqueue(2);

            // s += q;

            // Assert.AreEqual(s.Pop(), 2);
            // Assert.AreEqual(s.Pop(), 5);
            // Assert.AreEqual(s.Pop(), 4);
            // Assert.AreEqual(s.Pop(), 1);
            // Assert.AreEqual(s.Pop(), 20);
            // Assert.AreEqual(s.Pop(), 50);
            // Assert.AreEqual(s.Pop(), 40);
            // Assert.AreEqual(s.Pop(), 10);

            // /* For stack + stack */
            // MyStack<int> s1 = new MyStack<int>();
            // s1.Push(10);
            // s1.Push(40);
            // s1.Push(50);
            // s1.Push(20);

            // MyStack<int> s2 = new MyStack<int>();
            // s2.Push(1);
            // s2.Push(4);
            // s2.Push(5);
            // s2.Push(2);

            // s1 += s2;

            // Assert.AreEqual(s1.Pop(), 1);
            // Assert.AreEqual(s1.Pop(), 4);
            // Assert.AreEqual(s1.Pop(), 5);
            // Assert.AreEqual(s1.Pop(), 2);
            // Assert.AreEqual(s1.Pop(), 20);
            // Assert.AreEqual(s1.Pop(), 50);
            // Assert.AreEqual(s1.Pop(), 40);
            // Assert.AreEqual(s1.Pop(), 10);

        }
    }
}