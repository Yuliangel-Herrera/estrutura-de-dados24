using System;
using System.Collections.Generic;

namespace Exercicioss
{
    public class QuizItem
    {
        public string Text { get; set; }
        public QuizItem(string text) => Text = text;
    }

    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<QuizItem> tree = GetTree();
            BinaryTreeNode<QuizItem> node = tree.Root;

            while (node != null)
            {
                if (node.Left != null || node.Right != null)
                {
                    Console.Write(node.Data.Text + " (Y/N): ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        WriteAnswer("Y");
                        node = node.Left;
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        WriteAnswer("N");
                        node = node.Right;
                    }
                    else
                    {
                        WriteAnswer("Resposta invalida. Por favor responder sim ou não.");
                    }
                }
                else
                {
                    WriteAnswer(node.Data.Text);
                    node = null; // Set node to null to exit the loop
                }
            }
        }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>
            {
                Root = new BinaryTreeNode<QuizItem>
                {
                    Data = new QuizItem("?"),
                    Left = new BinaryTreeNode<QuizItem>
                    {
                        Data = new QuizItem("Possui experiencia de trabalho na area?"),
                        Left = new BinaryTreeNode<QuizItem>
                        {
                            Data = new QuizItem("Aplica para vaga")
                        },
                        Right = new BinaryTreeNode<QuizItem>
                        {
                            Data = new QuizItem("Aplica com aprendiz")
                        }
                    },
                    Right = new BinaryTreeNode<QuizItem>
                    {
                        Data = new QuizItem("Possui estudo superior?"),
                        Left = new BinaryTreeNode<QuizItem>
                        {
                            Data = new QuizItem("Aplica para vaga")
                        },
                        Right = new BinaryTreeNode<QuizItem>
                        {
                            Data = new QuizItem("Tem alguma fobia"),
                            Left = new BinaryTreeNode<QuizItem>
                            {
                                Data = new QuizItem("Aplica!")
                            },
                            Right = new BinaryTreeNode<QuizItem>
                            {
                                Data = new QuizItem("Aplica!")
                            }
                        }
                    }
                },
                Count = 9
            };
            return tree;
        }

        private static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}