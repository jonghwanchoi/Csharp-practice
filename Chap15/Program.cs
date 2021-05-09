using System;
using Chap15library;

namespace Chap15
{
    class Program
    {
        static void Main(string[] args)
        {
            FromClass fromClass = new FromClass();
            fromClass.exam();

            SimpleLinq simpleLinq = new SimpleLinq();
            simpleLinq.exam();

            FromFrom fromFrom = new FromFrom();
            fromFrom.exam();

            GroupByClass groupByClass = new GroupByClass();
            groupByClass.exam();

            JoinClass joinClass = new JoinClass();
            joinClass.exam();
        }
    }
}
