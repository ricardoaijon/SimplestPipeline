# SimplestPipeline
Factory to build pipeline
-----------------------------------

building readme....

Install :
   
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
 
 Copyright and License

Copyright .NET Foundation

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this work except in compliance with the License. You may obtain a copy of the License in the LICENSE file, or at:

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
  
  
