module TemplateModule.Tests

open System
open NUnit.Framework
open ProjectName


[<Test>]
let dummyMethodWorks() =
    let expected = "Hello World"
    let result =  TemplateModule.dummyFunction "World"
    Assert.AreEqual(expected, result)