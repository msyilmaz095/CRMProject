
/* Smart UI v9.4.16 (2021-07-17) 
Copyright (c) 2011-2021 jQWidgets. 
License: https://htmlelements.com/license/ */ //

Smart("smart-multi-input",class extends Smart.Input{static get properties(){return{dropDownButtonPosition:{allowedValues:["none","left","right"],defaultReflectToAttribute:!0,value:"right",type:"string"},separator:{value:", ",type:"string"},selectedValues:{value:[],type:"array"}}}_performSelect(e){const t=this;if(!e)return void t.close();const a=e.target?e.target.closest("li"):e;if(!a)return;t._selectedItems||(t._selectedItems=[]),a.classList.toggle("active");const l=a.classList.contains("active"),s={label:a.getAttribute("data-label"),value:a.getAttribute("value")};if(l)t._selectedItems.push(s),a.setAttribute("aria-selected",!0),t._setActiveDescendant(a);else{const e=t._selectedItems.findIndex((e=>e.label===s.label&&e.value===s.value));e>-1&&t._selectedItems.splice(e,1),a.setAttribute("aria-selected",!1)}a.setAttribute("aria-selected",l);const r=t._selectedItems,i=t.value,n=t.$.input.dataValue;let[o,u]=[[],[]];for(let e=0;e<r.length;e++){const t=r[e];o.push(t.label),u.push(t.value)}t.set("selectedValues",r.map((e=>e.value))),o=o.join(t.separator),t.set("value",o),t.$.input.dataValue=u=u.join(t.separator),o===i&&u===n||t.$.fireEvent("change",{value:u,label:o,oldValue:n,oldLabel:i})}close(){const e=this;return!!e.opened&&(e.timer&&clearTimeout(e.timer),e.timer=setTimeout((function(){e.$.scrollView.parentNode&&!e.opened&&(e.$.scrollView.remove(),e.removeAttribute("aria-owns"),e.readonly||e.$.input.removeAttribute("aria-controls"))}),1e3),e.$.scrollView.removeAttribute("open"),e.$.dropDownButton.removeAttribute("open"),e.$.input.removeAttribute("open"),e.removeAttribute("open"),e.opened=!1,e.setAttribute("aria-expanded",!1),e.$.input.focus(),!0)}open(){const e=this;let t;e.dropDownDataSource?(e.query="",t="function"==typeof e.dataSource?e.dataSource(e.query):e.dataSource):t="function"==typeof e.dropDownDataSource?e.dropDownDataSource(e.query):e.dropDownDataSource,e._process(t),e.ensureVisible(),e.$.input.focus(),setTimeout((function(){e.$.input.focus()}),25)}_render(e){const t=this,a=e.map((function(e){let a=e,l=e;"object"==typeof e&&(a=e.label,l=void 0!==e.value?e.value:a);const s=document.createElement("li"),r=document.createElement("a");return r.href="#",s.id=t.id+"Item"+Math.floor(65536*(1+Math.random())).toString(16).substring(1),s.setAttribute("data-label",a),s.setAttribute("value",l),s.setAttribute("role","option"),s.setAttribute("aria-selected",!1),s.setAttribute("aria-label",a),r.innerHTML=t.highlighter?t.highlighter(a):t._highlighter(a),r.setAttribute("aria-hidden",!0),e.icon&&(r.classList.add("icon"),r.classList.add(e.icon)),s.appendChild(r),s}));t.$.menu.innerHTML="";let l=[],s=[],r=t._selectedItems;r||(r=t._selectedItems=[]);const i=r.length;r.length&&r.forEach((e=>{s.push(e.label),l.push(e.value)})),l=l.concat((t.$.input.dataValue||t.$.input.value).split(",").map((e=>e.trim()))),s=s.concat(t.$.input.value.split(",").map((e=>e.trim())));for(let e=0;e<a.length;e++){const n=a[e],o=n.getAttribute("value"),u=n.getAttribute("data-label"),c=i?l.indexOf(o):s.indexOf(u);c>-1&&s[c]===u&&(n.classList.add("active"),n.setAttribute("aria-selected",!0),t._setActiveDescendant(n),r.findIndex((e=>e.label===u&&e.value===o))<0&&r.push({label:n.getAttribute("data-label"),value:n.getAttribute("value")})),t.$.menu.appendChild(n)}t.set("selectedValues",r.map((e=>e.value)))}_next(){const e=this;let t=e._selectedItems?e._selectedItems[e._selectedItems.length-1]:void 0;t&&(t=e.$.menu.querySelector(`.active[data-label="${t.label}"][value="${t.value}"]`));const a=t||e.$.menu.querySelector(".active");if(!a){const t=e.$.menu.firstElementChild;return void e._performSelect(t)}e._selectedItems&&(e._selectedItems=[]);const l=e.$.menu.children;for(let e=0;e<l.length;e++)l[e].classList.remove("active"),l[e].setAttribute("aria-selected",!1);e._setActiveDescendant();let s=a.nextElementSibling;s||(s=e.$.menu.firstElementChild),e._performSelect(s),e.ensureVisible()}_prev(){const e=this;let t=e._selectedItems?e._selectedItems[e._selectedItems.length-1]:void 0;t&&(t=e.$.menu.querySelector(`.active[data-label="${t.label}"][value="${t.value}"]`));const a=t||e.$.menu.querySelector(".active");if(!a){const t=e.$.menu.firstElementChild;return void e._performSelect(t)}e._selectedItems&&(e._selectedItems=[]);const l=e.$.menu.children;for(let e=0;e<l.length;e++)l[e].classList.remove("active"),l[e].setAttribute("aria-selected",!1);e._setActiveDescendant();let s=a.previousElementSibling;s||(s=e.$.menu.lastElementChild),e._performSelect(s),e.ensureVisible()}_keyUpHandler(e){const t=this;if(!e.shiftKey)switch(e.keyCode){case 40:case 38:case 16:case 17:case 18:40===e.keyCode&&e.altKey&&t.open(),38===e.keyCode&&e.altKey&&t.close();break;case 9:case 13:if(!t.opened)return;t._performSelect(),e.stopPropagation(),e.preventDefault();break;case 27:if(!t.opened)return;t.close(),e.stopPropagation(),e.preventDefault();break;default:t._lookup(e),!t.opened||e.ctrlKey||e.shiftKey||(e.stopPropagation(),e.preventDefault()),t.readonly||(t.$.input.dataValue=t.$.input.value)}}propertyChangedHandler(e,t,a){const l=this;if("value"===e){l.displayMember!==l.valueMember&&"string"!=typeof a?(l.value=a[l.displayMember],l.$.input.dataValue=a[l.valueMember]):l.$.input.dataValue=l.$.input.value=a,l._selectedItems=[],l.set("selectedValues",[]);const e=l.$.menu.children;for(let t=0;t<e.length;t++)e[t].classList.remove("active"),e[t].setAttribute("aria-selected",!1);l._setActiveDescendant()}else"separator"===e?(l.set("value",l.value.replace(new RegExp(t,"g"),a)),l.$.input.dataValue&&(l.$.input.dataValue=l.$.input.dataValue.replace(new RegExp(t,"g"),a))):super.propertyChangedHandler(e,t,a)}_createElement(){const e=this,t=document.createElement("ul"),a=document.createElement("smart-scroll-viewer");a.rightToLeft=e.rightToLeft,a.theme=e.theme,a.horizontalScrollBarVisibility="hidden",a.classList.add("smart-multi-input-drop-down-menu"),e.inverted?a.setAttribute("inverted",""):a.removeAttribute("inverted"),e.classList.add("smart-input"),t.setAttribute("aria-multiselectable",!0),e.$.scrollView=a,e.$.menu=t,e.$.menu.onclick=function(t){t.stopPropagation(),t.preventDefault(),e._performSelect(t),e.$.input.focus()}}_setActiveDescendant(e){const t=this;t.readonly||(e?t.setAttribute("aria-activedescendant",e.id):t.removeAttribute("aria-activedescendant"))}});