﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trinity.TSL.Test.TestModules
{
    partial class TestCodeTemplate
    {

//        public static void GenerateTestCode(BitArrayType type, List<string> readySents, string workingSent, int depth, bool hasListOfStruct,bool isFollowingListIndexer)
//        {

//            int branch = (int)(r.NextDouble() * 7);
//            switch (branch)
//            {
//                //test indexer
//                case 0:
//                    readySents.Add(@"
//                   int length_" + depth + "= " + workingSent + @".Count;
//                   int index_" + depth + "= " + @"GetRandom(length_" + depth + ");");
//                    workingSent += "[index_" + depth + "] ";
//                    GenerateTestCode(new AtomType(TokenId.BoolType), readySents, workingSent, depth + 1, hasListOfStruct, true);
//                    readySents[readySents.Count - 1] = "if(length_" + depth + @">0)" + readySents[readySents.Count - 1];
//                    break;

//                //test Not
//                case 1:
//                    if (!hasListOfStruct)
//                    {
//                        TestCaseFactory.LogicOpearationOnBitArray = true;

//                        workingSent = workingSent + "=" + workingSent + ".Not();";
//                        readySents.Add(workingSent);
//                    }
//                    else
//                    {
//                        workingSent = "DoNothing(" + workingSent + ");";
//                        readySents.Add(workingSent);
//                    }
//                    break;

//                //test And
//                case 2:
//                    if (!hasListOfStruct)
//                    {
//                        TestCaseFactory.LogicOpearationOnBitArray = true;

//                        workingSent = workingSent + "=" + workingSent + ".And("+ObjectGenerator.generate(type)+");";
//                        readySents.Add(workingSent);
//                    }
//                    else
//                    {
//                        workingSent = "DoNothing(" + workingSent + ");";
//                        readySents.Add(workingSent);
//                    }
//                    break;

//                //test Xor
//                case 3:
//                    if (!hasListOfStruct)
//                    {
//                        TestCaseFactory.LogicOpearationOnBitArray = true;

//                        workingSent = workingSent + "=" + workingSent + ".Xor("+ObjectGenerator.generate(type)+");";
//                        readySents.Add(workingSent);
//                    }
//                    else
//                    {
//                        workingSent = "DoNothing(" + workingSent + ");";
//                        readySents.Add(workingSent);
//                    }
//                    break;

//                //test Or
//                case 4:
//                    if (!hasListOfStruct)
//                    {
//                        TestCaseFactory.LogicOpearationOnBitArray = true;

//                        workingSent = workingSent + "=" + workingSent + ".Or("+ObjectGenerator.generate(type)+");";
//                        readySents.Add(workingSent);
//                    }
//                    else
//                    {
//                        workingSent = "DoNothing(" + workingSent + ");";
//                        readySents.Add(workingSent);
//                    }
//                    break;

//                //test setall
//                case 5:
//                    readySents.Add(@"
//                        bool tmp_" + depth + " =  (r.NextDouble()>0.5?true:false);");
//                    workingSent += ".SetAll(tmp_" + depth + ");";
//                    readySents.Add(workingSent);
//                    break;
//                    //test =
//                case 6:
//                    if (!hasListOfStruct)
//                    {
//                        workingSent += "= " + ObjectGenerator.generate(type) + ";";
//                        readySents.Add(workingSent);
//                    }
//                    else
//                    {
//                        if (isFollowingListIndexer)
//                        {
//                        workingSent += "= " + ObjectGenerator.generate(type) + ";";
//                        readySents.Add(workingSent);
//                        }
//                        else
//                        {
//                            workingSent = "DoNothing(" + workingSent + ");";
//                            readySents.Add(workingSent);
//                        }
//                    }
//                    break;



//            }
                    
//        }
    }
}