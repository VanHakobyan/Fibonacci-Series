# Fibonacci-Series
### .net framework 4.6 , C# 6.0

<p align="center">
<img src="https://i.gyazo.com/9a4277daf63e03585780e17c1268529b.png">
</p>


<p>In <a href="https://en.wikipedia.org/wiki/Mathematics" title="Mathematics">mathematics</a>, the <b>Fibonacci numbers</b> are the numbers in the following <a href="https://en.wikipedia.org/wiki/Integer_sequence" title="Integer sequence">integer sequence</a>, called the <b>Fibonacci sequence</b>, and characterized by the fact that every number after the first two is the sum of the two preceding ones:<sup id="cite_ref-FOOTNOTEBeckGeoghegan2010_1-0" class="reference"><a href="#cite_note-FOOTNOTEBeckGeoghegan2010-1"></a></sup><sup id="cite_ref-FOOTNOTEB.C3.B3na2011180_2-0" class="reference"><a href="#cite_note-FOOTNOTEB.C3.B3na2011180-2"></a></sup></p>

<dl>
<dd><span><span class="mwe-math-mathml-inline mwe-math-mathml-a11y" style="display: none;"><math xmlns="http://www.w3.org/1998/Math/MathML">
  <semantics>
    <mrow class="MJX-TeXAtom-ORD">
      <mstyle displaystyle="true" scriptlevel="0">
        <mn>1</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>1</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>2</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>3</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>5</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>8</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>13</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>21</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>34</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>55</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>89</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mn>144</mn>
        <mo>,</mo>
        <mspace width="thickmathspace"></mspace>
        <mo>…<!-- … --></mo>
        <mspace width="thickmathspace"></mspace>
      </mstyle>
    </mrow>
    <annotation encoding="application/x-tex">{\displaystyle 1,\;1,\;2,\;3,\;5,\;8,\;13,\;21,\;34,\;55,\;89,\;144,\;\ldots \;}</annotation>
  </semantics>
</math></span><img src="https://wikimedia.org/api/rest_v1/media/math/render/svg/7951ca1f26aebf2afbb3eb7f30c4725e635a79b3" class="mwe-math-fallback-image-inline" aria-hidden="true" style="vertical-align: -0.671ex; width:45.939ex; height:2.509ex;" alt="1,\;1,\;2,\;3,\;5,\;8,\;13,\;21,\;34,\;55,\;89,\;144,\;\ldots \;"></span></dd>
</dl>


```c#
static IEnumerable<int> GetCalculatedFibonacciSequence()
{
  var current = 1;
  var b = 0;
  var next = 0;
  yield return next;
  yield return current;
  while (true)
  {
      next = current + b;
      yield return next;
      b = current;
      current = next;
  }
}

```
