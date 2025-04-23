namespace Exam1.Test;

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StringComparisonTests
{
    [TestMethod]
    public void Q8_StringLengthComparer_Test()
    {        
    

     var comparer = new Q8StringLengthComparer();

       
        Assert.IsTrue(comparer.Compare(null, "") < 0);
        Assert.IsTrue(comparer.Compare("x", null) > 0);
        Assert.AreEqual(0, comparer.Compare(null, null));

       
        Assert.IsTrue(comparer.Compare("a", "bb") < 0);
        Assert.IsTrue(comparer.Compare("ccc", "dd") > 0);

        
        Assert.IsTrue(comparer.Compare("ab", "ac") < 0);
        Assert.AreEqual(0, comparer.Compare("same", "same"));

       
        string[] arr = { "apple", "pie", "banana", "kiwi", null, "app" };
        Array.Sort(arr, comparer);
        CollectionAssert.AreEqual(
            new[] { null, "app", "pie",  "kiwi", "apple", "banana" },
            arr
        );
        
    }

    [TestMethod]
    public void Q9_ComparableStringOperators_Test()
    {
        

        
        var a1 = new Q8ComparableString("a");
        var b2 = new Q8ComparableString("bb");
        var a2 = new Q8ComparableString("aa");
        var a2b = new Q8ComparableString("aa"); 

        
        Assert.IsTrue(a1 < b2,   "'a' (1) < 'bb' (2)");
        Assert.IsTrue(b2 > a1,   "'bb' (2) > 'a' (1)");
        Assert.IsFalse(a2 > b2,  "'aa' (2) !> 'bb' (2) - alphabetical 'aa'<'bb'");
        Assert.IsTrue(a2 < b2);

        
        Assert.IsTrue(a2 == a2b, "same length & same text → equal");
        Assert.IsFalse(a2 != a2b);
        var c = new Q8ComparableString(null);
        var d = new Q8ComparableString(null);
        Assert.IsTrue(c == d,   "null vs null → equal wrapper");
        Assert.IsFalse(c != d);

        
        Assert.IsTrue(c < a1,    "null.Value < non-null");
        Assert.IsFalse(c > a1);
        Assert.IsTrue(a1 > c);
        Assert.IsFalse(a1 < c);
        
    }
}
