using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A8.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void QueueConstructorTest()
        {
            MyQueue<int> qint = new MyQueue<int>();
            Assert.AreEqual(qint.Size, 0);
            Assert.AreEqual(qint.Values.Count, 0);

            MyQueue<string> qstring = new MyQueue<string>();
            Assert.AreEqual(qstring.Size, 0);
            Assert.AreEqual(qstring.Values.Count, 0);
        }

        [TestMethod]
        public void EnqueueDequeueTest()
        {
            MyQueue<int> qint = new MyQueue<int>();
            qint.Enqueue(1);
            qint.Enqueue(5);
            qint.Enqueue(4);
            qint.Enqueue(2);
            Assert.AreEqual(qint.Dequeue(), 1);
            Assert.AreEqual(qint.Dequeue(), 5);
            Assert.AreEqual(qint.Size, 2);

            MyQueue<string> qstring = new MyQueue<string>();
            qstring.Enqueue("Friend!");
            qstring.Enqueue("My");
            qstring.Enqueue("Hello");
            Assert.AreEqual(qstring.Dequeue(), "Friend!");
            qstring.Enqueue("World!");
            Assert.AreEqual(qstring.Size, 3);
            qstring.Dequeue();
            qstring.Dequeue();
            qstring.Dequeue();
            Assert.AreEqual(qstring.Size, 0);
        }
        [TestMethod]
        public void QueuePrintTest()
        {
            MyQueue<int> qint = new MyQueue<int>();
            qint.Enqueue(1);
            qint.Enqueue(5);
            qint.Enqueue(4);
            qint.Enqueue(2);
            Assert.AreEqual(qint.Print(), "1 5 4 2");

            MyQueue<string> qstring = new MyQueue<string>();
            qstring.Enqueue("Hello");
            qstring.Enqueue("My");
            qstring.Enqueue("Friend!");
            Assert.AreEqual(qstring.Print(), "Hello My Friend!");
            qstring.Dequeue();
            qstring.Enqueue(":)");
            Assert.AreEqual(qstring.Print(), "My Friend! :)");
        }
        [TestMethod]
        public void QueueEnumerableTest()
        {
            MyQueue<int> qint = new MyQueue<int>();
            qint.Enqueue(1);
            qint.Enqueue(5);
            qint.Enqueue(4);
            qint.Enqueue(2);
            int[] res = new int[] { 1, 5, 4, 2 };
            int i = 0;
            foreach (int val in qint)
            {
                Assert.AreEqual(val, res[i]);
                i++;
            }
            Assert.AreEqual(qint.Size, 4);

            MyStack<string> qstring = new MyStack<string>();
            qstring.Push("Friend!");
            qstring.Push("My");
            qstring.Push("Hello");
            string[] res2 = new string[] { "Hello", "My", "Friend!" };
            i = 0;
            foreach (string s in qstring)
            {
                Assert.AreEqual(s, res2[i]);
                i++;
            }
            Assert.AreEqual(qstring.Size, 3);
        }
    }
}