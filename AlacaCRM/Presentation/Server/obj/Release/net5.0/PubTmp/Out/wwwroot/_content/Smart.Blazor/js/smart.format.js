
/* Smart UI v9.4.16 (2021-07-17) 
Copyright (c) 2011-2021 jQWidgets. 
License: https://htmlelements.com/license/ */ //

Smart.Utilities.Assign("ConditionalFormatter",class{constructor(e){const t=this;t.data=e||[],t._allowedDateComparators=["yesterday","today","tomorrow","last7Days","lastWeek","thisWeek","nextWeek","lastMonth","thisMonth","nextMonth","lastYear","thisYear","nextYear"],t._colorSchemes=[{name:"scheme01",colors:["#307DD7","#AA4643","#89A54E","#71588F","#4198AF"]},{name:"scheme02",colors:["#7FD13B","#EA157A","#FEB80A","#00ADDC","#738AC8"]},{name:"scheme03",colors:["#E8601A","#FF9639","#F5BD6A","#599994","#115D6E"]},{name:"scheme04",colors:["#D02841","#FF7C41","#FFC051","#5B5F4D","#364651"]},{name:"scheme05",colors:["#25A0DA","#309B46","#8EBC00","#FF7515","#FFAE00"]},{name:"scheme06",colors:["#0A3A4A","#196674","#33A6B2","#9AC836","#D0E64B"]},{name:"scheme07",colors:["#CC6B32","#FFAB48","#FFE7AD","#A7C9AE","#888A63"]},{name:"scheme08",colors:["#3F3943","#01A2A6","#29D9C2","#BDF271","#FFFFA6"]},{name:"scheme09",colors:["#1B2B32","#37646F","#A3ABAF","#E1E7E8","#B22E2F"]},{name:"scheme10",colors:["#5A4B53","#9C3C58","#DE2B5B","#D86A41","#D2A825"]},{name:"scheme11",colors:["#993144","#FFA257","#CCA56A","#ADA072","#949681"]},{name:"scheme12",colors:["#105B63","#EEEAC5","#FFD34E","#DB9E36","#BD4932"]},{name:"scheme13",colors:["#BBEBBC","#F0EE94","#F5C465","#FA7642","#FF1E54"]},{name:"scheme14",colors:["#60573E","#F2EEAC","#BFA575","#A63841","#BFB8A3"]},{name:"scheme15",colors:["#444546","#FFBB6E","#F28D00","#D94F00","#7F203B"]},{name:"scheme16",colors:["#583C39","#674E49","#948658","#F0E99A","#564E49"]},{name:"scheme17",colors:["#142D58","#447F6E","#E1B65B","#C8782A","#9E3E17"]},{name:"scheme18",colors:["#4D2B1F","#635D61","#7992A2","#97BFD5","#BFDCF5"]},{name:"scheme19",colors:["#844341","#D5CC92","#BBA146","#897B26","#55591C"]},{name:"scheme20",colors:["#56626B","#6C9380","#C0CA55","#F07C6C","#AD5472"]},{name:"scheme21",colors:["#96003A","#FF7347","#FFBC7B","#FF4154","#642223"]},{name:"scheme22",colors:["#5D7359","#E0D697","#D6AA5C","#8C5430","#661C0E"]},{name:"scheme23",colors:["#16193B","#35478C","#4E7AC7","#7FB2F0","#ADD5F7"]},{name:"scheme24",colors:["#7B1A25","#BF5322","#9DA860","#CEA457","#B67818"]},{name:"scheme25",colors:["#0081DA","#3AAFFF","#99C900","#FFEB3D","#309B46"]},{name:"scheme26",colors:["#0069A5","#0098EE","#7BD2F6","#FFB800","#FF6800"]},{name:"scheme27",colors:["#FF6800","#A0A700","#FF8D00","#678900","#0069A5"]},{name:"scheme28",colors:["#63BE7B","#FDD17F","#F8696B"]},{name:"scheme29",colors:["#F8696B","#FDD17F","#63BE7B"]},{name:"scheme30",colors:["#63BE7B","#FCFCFF","#F8696B"]},{name:"scheme31",colors:["#F8696B","#FCFCFF","#63BE7B"]},{name:"scheme32",colors:["#5A8AC6","#FCFCFF","#F8696B"]},{name:"scheme33",colors:["#F8696B","#FCFCFF","#5A8AC6"]},{name:"scheme34",colors:["#FCFCFF","#F8696B"]},{name:"scheme35",colors:["#F8696B","#FCFCFF"]},{name:"scheme36",colors:["#63BE7B","#FCFCFF"]},{name:"scheme37",colors:["#FCFCFF","#63BE7B"]},{name:"scheme38",colors:["#63BE7B","#FFEF9C"]},{name:"scheme39",colors:["#FFEF9C","#63BE7B"]},{name:"scheme40",colors:["#000000","#8b0000 ","#FFFF00","#FFFFFF"]},{name:"scheme41",colors:["#63BE7B","#FDD17F ","#F8696B","#FF69B4"]},{name:"scheme42",colors:["#63BE7B","#FDD17F ","#FDD17F","#F8696B"]},{name:"scheme00",colors:["#63BE7B","#FDD17F","#FDD17F","#FDD17F","#F8696B"]}]}format(e,t,o){const a=this,r=a.data;if(0===r.length)return;if(e?a.condition=e:e=a.condition,!e)return;void 0!==a.comparator&&null!==a.comparator||(a.comparator=o),t?a.columns=t:t=a.columns,a.color&&(a.color=/^#[0-9A-F]{6}$/i.test(a.color)?a.color:void 0),(!t||!Array.isArray(t)||Array.isArray(t)&&0===t.length)&&(t=a.columns=[]);let n={};for(let e=0;e<t.length;e++){const o=t[e];void 0!==r[0][o]&&(n[o]=a._validateColumnData(o))}return 0!==Object.keys(n).length?n:void 0}_applyColorScale(e){const t=this,o=e.length;function a(e){let t=0;for(;t<i;){if(e<=c[t].max)return t;t++}return Math.max(0,Math.min(i-1,t))}if(0===o)return;const r=void 0!==t.colorScheme?t._getSchemeColors():[t.color];if(0===r.length||void 0===r[0]||null===r[0])return;let n,l,s={},c={};const i=r.length-("iconSet"===t.condition?0:1),m=t._getColumnRange(e),F=parseFloat(t.min)||m.min,h=Math.max(F,parseFloat(t.max)||m.max);for(let e=0;e<i;e++)c[e]={min:c[e-1]?c[e-1].max:F,max:F+(e+1)/i*(h-F)};0===i&&(c[0]={min:F,max:h});for(let m=0;m<o;m++){let o=e[m]instanceof Date?e[m].getTime():e[m];o=Math.min(h,Math.max(F,o)),"number"==typeof o&&(n=a(o)||0,"iconSet"===t.condition?s[m]={"--icon-set":" ","--icon-set-color":r[n],"--icon-set-rotation-angle":t._getRotationAngle(n/(i-1)||0)+"deg"}:(l=1-((o-c[n].min)/(c[n].max-c[n].min)||0),s[m]=t._getCellStyle(t._mixColors(r[n],r[Math.min(n+1,i)],l))))}return s}_applyColorBar(e){const t=this,o=e.length,a=t._getColumnRange(e),r=t.min?parseFloat(t.min)||0:a.min,n=t.max?parseFloat(t.max)||0:a.max,l=void 0!==t.colorScheme?t._getSchemeColors():[t.color];let s,c="",i={};for(let e=0;e<l.length;e++)void 0!==l[e]&&null!==l[e]&&(c+=l[e]+",");if(c){c=c.slice(0,-1),s=1===l.length?l[0]:"-webkit-linear-gradient(left,"+c+")";for(let t=0;t<o;t++){let o=e[t]instanceof Date?e[t].getTime():e[t];o=Math.min(n,Math.max(r,e[t])),"number"==typeof o&&(i[t]={"--color-bar":" ","--bar-width":((o-r)/(n-r)*100||0)+"%","--bar-color":s})}return i}console.log("Invalid color/colorScheme detected.")}_applyRule(e){const t=this,o=e.length,a="string"==typeof t.condition?t.condition.trim():"";let r,n,l,s=parseFloat(t.min)||0,c=Math.max(s,parseFloat(t.max)||0);function i(i){switch(a){case"between":if(i instanceof Date&&(i=i.getTime()),i>=s&&i<=c)return i;break;case"contains":if((i+"").indexOf(r)>-1)return i;break;case"duplicate":{let t=0;for(let a=0;a<o;a++)if(e[a]===i&&t++,t>1)return i;break}case"dateOccur":{const e=t._getDateRange(i,r);if(!e)break;if(i=new Date(i),isNaN(i.getTime()))break;const o=i.getTime(),a=e.min.getTime(),n=e.max.getTime();if(o>=a&&o<=n)return i;break}case"doesNotContain":if((i+"").indexOf(r)<0)return i;break;case"equal":if("number"==typeof i&&i===parseFloat(r))return i;if("string"==typeof i&&0===i.localeCompare(r+""))return i;if("boolean"==typeof i&&i+""==r+"")return i;if(i instanceof Date&&i.getTime()===new Date(r).getTime())return i;break;case"greaterThan":if(i>parseFloat(r))return i;break;case"lessThan":if(i<parseFloat(r))return i;break;case"notEqual":if("number"==typeof i&&i!==parseFloat(r))return i;if("string"==typeof i&&0!==i.localeCompare(r+""))return i;if("boolean"==typeof i&&i+""!=r+"")return i;if(i instanceof Date&&i.getTime()!==new Date(r).getTime())return i;break;case"topNItems":case"bottomNItems":case"topNPercent":case"bottomNPercent":if(n||(n=e.slice(0).sort(0===a.indexOf("top")?(e,t)=>e<t?1:e>t?-1:0:(e,t)=>e>t?1:e<t?-1:0).slice(0,parseInt(a.indexOf("Percent")>0?o*r/100:r))),n.indexOf(i)>-1)return i;break;case"aboveAverage":case"belowAverage":if(!l){let t=0;e.map((e=>t+=parseFloat(e))),l=t/o}if("aboveAverage"===a&&i>l)return i;if("belowAverage"===a&&i<l)return i}return null}if(r="dateOccur"===a?"string"==typeof t.comparator&&t._allowedDateComparators.indexOf(t.comparator.trim())>-1?t.comparator.trim():void 0:Array.isArray(t.comparator)?t.comparator[0].trim():t.comparator,!e||0===e.length)return;if(["odd","even","duplicate","dateOccur","between","aboveAverage","belowAverage"].indexOf(a)<0&&0!==a.indexOf("everyN")&&null==r)return console.warn(t.condition+" requires a comparator."),[];if("odd"===a||"even"===a||0===a.indexOf("everyN"))return t._getAlternateItems(e);let m,F=[];for(let t=0;t<o;t++)m=i(e[t]),null!=m&&F.push(t);return F}_getAlternateItems(e){const t=this,o=e.length,a="string"==typeof t.condition?t.condition.trim():"",r=parseInt(t.min)||0,n=Math.max(r,parseInt(t.max)||o)-1,l=parseInt(t.comparator);let s=[],c=0;for(let e=0;e<=o;e++)if(!(e<r)){if(e>n)break;"even"===a&&(e+1)%2==0||"odd"===a&&(e+1)%2!=0?s.push(e):void 0===l||isNaN(l)||(c===l?(s.push(e),c=0):c++)}return s}_getColumnRange(e){const t=e.length;let o,a,r=0;for(let n=0;n<t;n++)a=e[n],a instanceof Date&&(a=a.getTime()),a>r&&(r=a),void 0===o&&(o=a),a<o&&(o=a);return{min:parseFloat(o)||0,max:parseFloat(r)||0}}_getCellStyle(e,t){var o=e;return{background:this._hexToRgba(e,t).toString(),color:this._getTextElementByColor(this._hexToRgba(e,.7)),border:o}}_getDateRange(e,t){let o,a;if(!(new Date(e)instanceof Date&&t))return;const r=new Date;switch(t){case"yesterday":case"today":case"tomorrow":"yesterday"===t?a=new Date(r.getFullYear(),r.getMonth(),r.getDate()-1):"today"===t?(a=new Date,a.setHours(0,0,0,0)):a=new Date(r.getFullYear(),r.getMonth(),r.getDate()+1),o=a;break;case"last7Days":a=new Date(r.getFullYear(),r.getMonth(),r.getDate()-6),o=new Date(r);break;case"lastWeek":case"thisWeek":case"nextWeek":a="lastWeek"===t?new Date(r.getFullYear(),r.getMonth(),r.getDate()-6-r.getDay()):"thisWeek"===t?new Date(r.getFullYear(),r.getMonth(),r.getDate()-Math.abs(1-r.getDay())):new Date(r.getFullYear(),r.getMonth(),r.getDate()+Math.abs(7-r.getDay())),o=new Date(a.getFullYear(),a.getMonth(),a.getDate()+6);break;case"lastMonth":case"thisMonth":case"nextMonth":"lastMonth"===t?(o=new Date(r.getFullYear(),r.getMonth(),0),a=new Date(o.getFullYear(),o.getMonth(),1)):"thisMonth"===t?(a=new Date(r.getFullYear(),r.getMonth(),1),o=new Date(r.getFullYear(),r.getMonth()+1,0)):(a=new Date(r.getFullYear(),r.getMonth()+1,1),o=new Date(r.getFullYear(),r.getMonth()+2,0));break;case"lastYear":case"thisYear":case"nextYear":"lastYear"===t?(a=new Date(r.getFullYear()-1,0,1),o=new Date(r.getFullYear()-1,12,0)):"thisYear"===t?(a=new Date(r.getFullYear(),0,1),o=new Date(r.getFullYear(),12,0)):(a=new Date(r.getFullYear()+1,0,1),o=new Date(r.getFullYear()+1,12,0))}return{min:a,max:o}}_getRotationAngle(e){let t=e;return e<.25?t=Math.round(e)?.25:0:e>.25&&e<.5?t=Math.round(e)?.5:.25:e>.5&&e<.75?t=Math.round(e)?.75:.5:e>.75&&e<1&&(t=Math.round(e)?1:.75),180*t}_getSchemeColors(){const e=this;let t;if("string"==typeof e.colorScheme)t=0===e.colorScheme.indexOf("scheme")?e._colorSchemes.filter((t=>t.name===e.colorScheme))[0]:void 0;else{if("number"!=typeof e.colorScheme)return[];t=e._colorSchemes[e.colorScheme]?e._colorSchemes[e.colorScheme]:void 0}return"object"==typeof t?t.colors:e._colorSchemes[0].colors}_getTextElementByColor(e){return.299*e.r+.587*e.g+.114*e.b>=125?"Black":"White"}_hexToRgba(e,t){const o=/^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(e);var a=function(){return this.alpha>1||void 0===this.alpha||null===this.alpha?this.alpha=1:this.alpha<0&&(this.alpha=0),"rgba("+this.r+", "+this.g+", "+this.b+", "+this.alpha+")"};return void 0===t?o?{r:parseInt(o[1],16),g:parseInt(o[2],16),b:parseInt(o[3],16),toString:a}:null:(t>1?t=1:t<0&&(t=0),o?{r:parseInt(o[1],16),g:parseInt(o[2],16),b:parseInt(o[3],16),alpha:t,toString:a}:null)}_mixColors(e,t,o){const a=e=>parseInt(e,16);let r,n="#";o=void 0!==o?o:.5,e=e.replace(/#/g,""),t=t.replace(/#/g,"");for(let l=0;l<=5;l+=2){const s=a(e.substr(l,2)),c=a(t.substr(l,2));for(r=Math.floor(c+(s-c)*o).toString(16);r.length<2;)r="0"+r;n+=r}return n}_shadeColor(e,t){var o=parseInt(e.slice(1),16),a=t<0?0:255,r=t<0?-1*t:t,n=o>>16,l=o>>8&255,s=255&o;return"#"+(16777216+65536*(Math.round((a-n)*r)+n)+256*(Math.round((a-l)*r)+l)+(Math.round((a-s)*r)+s)).toString(16).slice(1)}_validateColumnData(e){const t=this,o=[],a=t.data;let r,n={};for(let t=0;t<a.length;t++)a[t]&&o.push(a[t][e]);if("colorScale"===t.condition||"iconSet"===t.condition)return t._applyColorScale(o);if("colorBar"===t.condition)return t._applyColorBar(o);if(r=t._applyRule(o),r){if(t.color){for(let e=0;e<r.length;e++)n[r[e]]=t._getCellStyle(t.color);return n}console.warn('No color is provided. "color" property is not set.')}}});