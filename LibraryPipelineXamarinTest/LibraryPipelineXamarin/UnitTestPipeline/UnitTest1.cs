using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryPipelineXamarin.Factory;
using LibraryPipelineXamarin.Models;
using UnitTestPipeline.TestClasses;
using FactoryContext = UnitTestPipeline.TestClasses.FactoryContext;

namespace UnitTestPipeline
{
    [TestClass]
    public class UnitTest1
    {
        public async Task<object> GetResult(PipelineBase pi)
        {
            object x ="";
           
            await Task.Factory.StartNew(async () =>
            {
                
                await pi.ExecutePipeline();
                x =  pi.GetResult();
                do
                {
                    await Task.Delay(200);
                } while (x == null);
                return Task.FromResult(x);

            });
            return Task.FromResult(x);

        }

        [TestMethod]
        public  void TestMethodCrearePipeline()
        {
            var word1 = new WordPrase
            {
                Meaning = "Yo"
            };
            var word2 = new WordPrase
            {
                Meaning = "soy"
            };
            var word3 = new WordPrase()
            {
                Meaning = "CustomC#Unfunctional"
            };

            var listWords = new List<WordPrase>
            {
                word1,
                word2,
                word3
            };
            var context = new FactoryContext();
            context.SetType(listWords);
            var contexto=context.GetInstance();

            var pipelineFack = new FactoryPipeline<ContextPhase>().SetContext(contexto)
                .AddPipeline<PipelineSujeto>()
                .AddPipeline<PipelineVerbo>()
                .AddPipeline<PipelinePredicado>()
                .GetPipeline();

            var result=GetResult(pipelineFack).Result;


           
            var resultado = pipelineFack.GetResult();
                Assert.IsTrue(pipelineFack != null);



        
        }
    }
}
