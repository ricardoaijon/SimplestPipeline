# SimplestPipeline
Factory to build pipeline
-----------------------------------

building readme....

Example of use: 
   var context=new FactoryContext().SetType(TipoString).GetInstance();
   var pipeline=
                new FactoryPipeline<Context>().SetContext(context)
                    .AddPipeline<Sujeto>()
                    .AddPipeline<Verbo>()
                    .AddPipeline<Predicado>()
                    .GetPipeline();
  await pipeline.ExecutePipeline();
  var frase = pipeline.GetResult();
  
  *NOTE: Dont build the example as a Test, becouse it doesnt exist en solution provided, sorry. 
         Its just a conceptual sketch.
         
 Have Fun and Code :P
  
  
