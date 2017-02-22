<h2><u>Factory to build pipeline</u></h2>


<p><b>Install :</b></p>

<pre><b>Example of use:</b> 
   var context=new FactoryContext()
	.SetType(TipoString)
	.GetInstance();
   var pipeline=new FactoryPipeline()
	            .SetContext(context)
                    .AddPipeline()
                    .AddPipeline()
                    .AddPipeline()
                    .GetPipeline();
  await pipeline.ExecutePipeline();
  var frase = pipeline.GetResult();</b></pre>

<p>*NOTE: Dont build the example as a Test, becouse it doesnt exist en solution provided, sorry. 
         Its just a conceptual sketch.</p>

<p>Have Fun and Code :P</p>
-------------------------------------------------------
<h3>Copyright and License</h3>

<h5>Copyright .NET Foundation</h5>

<p>Licensed under the Apache License, Version 2.0 (the "License"); you may not use this work except in compliance with the License. You may obtain a copy of the License in the LICENSE file, or at:</p>

<p><a href="http://www.apache.org/licenses/LICENSE-2.0">http://www.apache.org/licenses/LICENSE-2.0</a></p>

<p>Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.</p>
</article>
 
