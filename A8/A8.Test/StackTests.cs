using Microsoft.VisualStudio.TestTools.UnitTesting;
using A8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackConstructorTest()
        {
            MyStack<int> sint = new MyStack<int>();
            Assert.AreEqual(sint.Size, 0);
            Assert.AreEqual(sint.Values.Count, 0);

            MyStack<string> sstring = new MyStack<string>();
            Assert.AreEqual(sstring.Size, 0);
            Assert.AreEqual(sstring.Values.Count, 0);
        }

        [TestMethod]
        public void StackPushPopTest()
        {
            MyStack<int> sint = new MyStack<int>();
            sint.Push(1);
            sint.Push(5);
            sint.Push(4);
            sint.Push(2);
            Assert.AreEqual(sint.Pop(), 2);
            Assert.AreEqual(sint.Pop(), 4);
            Assert.AreEqual(sint.Size, 2);

            MyStack<string> sstring = new MyStack<string>();
            sstring.Push("Hello");
            sstring.Push("My");
            sstring.Push("Friend!");
            Assert.AreEqual(sstring.Pop(), "Friend!");
            sstring.Push("Darling!");
            Assert.AreEqual(sstring.Size, 3);
            sstring.Pop();
            sstring.Pop();
            sstring.Pop();
            Assert.AreEqual(sstring.Size, 0);
        }
        [TestMethod]
        public void StackPrintTest()
        {
            MyStack<int> sint = new MyStack<int>();
            sint.Push(1);
            sint.Push(5);
            sint.Push(4);
            sint.Push(2);
            Assert.AreEqual(sint.Print(), "2 4 5 1");
            Assert.AreEqual(sint.Size, 4);

            MyStack<string> sstring = new MyStack<string>();
            sstring.Push("Friend!");
            sstring.Push("My");
            sstring.Push("Hello");
            Assert.AreEqual(sstring.Print(), "Hello My Friend!");
            Assert.AreEqual(sstring.Size, 3);

        }
        [TestMethod]
        public void StackEnumeratorTest()
        {
            MyStack<int> sint = new MyStack<int>();
            sint.Push(1);
            sint.Push(5);
            sint.Push(4);
            sint.Push(2);
            int[] res = new int[] { 2, 4, 5, 1 };
            int i = 0;
            foreach (int val in sint)
            {
                Assert.AreEqual(val, res[i]);
                i++;
            }
            Assert.AreEqual(sint.Size, 4);

            MyStack<string> sstring = new MyStack<string>();
            sstring.Push("Friend!");
            sstring.Push("My");
            sstring.Push("Hello");
            string[] res2 = new string[] { "Hello", "My", "Friend!" };
            i = 0;
            foreach (string s in sstring)
            {
                Assert.AreEqual(s, res2[i]);
                i++;
            }
            Assert.AreEqual(sstring.Size, 3);

        }
    }
}