
/* Smart UI v9.4.16 (2021-07-17) 
Copyright (c) 2011-2021 jQWidgets. 
License: https://htmlelements.com/license/ */ //

Smart("smart-input",class extends Smart.BaseElement{static get properties(){return{autoCompleteDelay:{value:100,type:"number"},dataSource:{type:"any",value:[],reflectToAttribute:!1},dropDownClassList:{value:[],type:"array",reflectToAttribute:!1},dropDownDataSource:{type:"any",value:[]},dropDownHeight:{type:"any",value:200},dropDownOpenMode:{allowedValues:["default","manual"],value:"default",type:"string"},dropDownWidth:{type:"any",value:null},dropDownButtonPosition:{allowedValues:["none","left","right"],value:"none",type:"string"},hint:{type:"string",value:""},inputPurpose:{type:"string",value:"off"},items:{type:"number",value:8},minLength:{type:"number",value:1},name:{value:"",type:"string"},opened:{value:!1,type:"boolean"},query:{type:"string",value:""},queryMode:{allowedValues:["contains","containsIgnoreCase","doesNotContain","doesNotContainIgnoreCase","equals","equalsIgnoreCase","startsWith","startsWithIgnoreCase","endsWith","endsWithIgnoreCase"],type:"string",value:"containsIgnoreCase"},placeholder:{value:"",type:"string"},readonly:{type:"boolean",value:!1},sorted:{value:!1,type:"boolean"},sortDirection:{value:"asc",type:"string"},selectedIndex:{type:"number",value:-1},selectedValues:{value:[],type:"array"},type:{type:"string"},value:{type:"string",value:""}}}static get styleUrls(){return["smart.textbox.css"]}template(){return'<div id="inputContainer" role="presentation"><input class="smart-input" id=\'input\' readonly=\'[[readonly]]\' placeholder=\'[[placeholder]]\' type=\'[[type]]\' name=\'[[name]]\' value=\'{{value::keyup}}\' disabled=\'[[disabled]]\' aria-label="[[placeholder]]" /><span class="smart-hidden smart-hint" id="span">[[hint]]</span><div id="dropDownButton" tabindex=-1 class="smart-drop-down-button" role="button" aria-label="Toggle popup"><div id="arrow" class="arrow" aria-hidden="true"></div></div></div>'}static get listeners(){return{"input.focus":"_focusHandler","input.blur":"_blurHandler","input.keydown":"_keyDownHandler","input.keyup":"_keyUpHandler","input.keypress":"_keyPressHandler","input.paste":"_pasteHandler","dropDownButton.down":"_dropDownButtonDownHandler","inputContainer.down":"_downHandler","document.up":"_documentUpHandler"}}focus(){this.$.input.focus()}select(){const e=this;e.readonly?e.$.input.focus():e.$.input.select()}_documentUpHandler(e){const t=this,o=t.shadowRoot||t.isInShadowDOM?e.originalEvent.composedPath()[0]:e.originalEvent.target;o!==t&&o!==t.$.dropDownButton&&o!==t.$.input&&o!==t.$.arrow?t.$.scrollView.contains(o.shadowParent||o)?t._isPointerDown&&(t._isPointerDown=!1,t.opened&&(t._preventLookup=!0),t.$.input.focus()):(t.opened&&(t._preventLookup=!0),"manual"===t.dropDownOpenMode||t._isPointerDown||t.close(),t._isPointerDown=!1):t._isPointerDown=!1}_focusHandler(){const e=this;e.setAttribute("focus",""),e.readonly||0!==e.minLength||0!==e.$.input.value.length||e._preventLookup?(e.$.fireEvent("focus"),delete e._preventLookup):e._lookup()}_blurHandler(){const e=this;e.opened||e.removeAttribute("focus"),e.opened||e.$.fireEvent("blur"),e._refreshSelectedIndex(),delete e._preventLookup}_pasteHandler(e){const t=this,o=(e.clipboardData||window.clipboardData).getData("text");e.preventDefault(),t.set("value",o),t.setAttribute("data-value",o),t._refreshSelectedIndex()}_refreshSelectedIndex(){const e=this;let t=e.dataSource;if(t){let o=-1;if(e.dataSource instanceof Promise)return;if("function"==typeof e.dataSource)return;"string"==typeof t&&(t=e.$.deserialize(t,"array"));for(let r=0;r<t.length;r++){let a=t[r];if("number"!=typeof a&&"boolean"!=typeof a||(a=""+a),"string"==typeof a){if(a===e.value){o=r;break}}else if(a&&a.label===e.value){o=r;break}}e.set("selectedIndex",o,!1),-1===e.selectedIndex&&(e.$.input.dataValue=null)}}selectItem(e){const t=this;let o=t.dataSource;if("string"==typeof o&&(o=t.$.deserialize(o,"array")),o)for(let r=0;r<o.length;r++){const a=o[r];if(t.set("selectedIndex",-1),t.set("value",""),t.$.input.dataValue=null,"string"==typeof a){if(a===e)return t.set("selectedIndex",r,!1),t.set("value",t.$.input.dataValue=e),void t.setAttribute("data-value",t.$.input.dataValue)}else if(a.value===e)return t.set("selectedIndex",r,!1),t.set("value",a.label),t.$.input.dataValue=e,void t.setAttribute("data-value",t.$.input.dataValue)}else t.set("value",t.$.input.dataValue=e),t.setAttribute("data-value",t.$.input.dataValue),t.set("selectedIndex",-1,!1)}getSelectedItem(){const e=this;return{label:e.value,value:e.$.input.dataValue||e.value}}_refreshMenu(){const e=this;e.$.menu.classList.remove("scroll"),e.$.scrollView.computedVerticalScrollBarVisibility&&e.$.menu.classList.add("scroll")}_performSelect(){const e=this,t=e.$.menu.querySelector(".active"),o=t.getAttribute("data-label"),r=t.dataValue,a=e.value,n=e.$.input.dataValue;e.set("value",o),e.$.input.dataValue=r,e.setAttribute("data-value",e.$.input.dataValue),e.set("selectedIndex",t.index),e.selectedValues=[e.$.input.dataValue],e.close(),o===a&&r===n||e.$.fireEvent("change",{value:r,label:o,oldValue:n,oldLabel:a})}_open(){const e=this;if(e.opened)return;const t=window.scrollX,o=window.scrollY;let r=e.getBoundingClientRect(),a=0,n=0;if(e.timer&&clearTimeout(e.timer),e.getRootNode()&&e.getRootNode().host?e.getRootNode().host.shadowRoot.appendChild(e.$.scrollView):document.body.appendChild(e.$.scrollView),e.setAttribute("aria-owns",e.$.scrollView.id),e.readonly||e.$.input.setAttribute("aria-controls",e.$.scrollView.id),e.$.scrollView.enableShadowDOM&&!e._importedStyle&&(e.$.scrollView.importStyle(e._getStyleUrl("smart.textbox.css")),e._importedStyle=!0),"static"!==getComputedStyle(document.body).position){const e=document.body.getBoundingClientRect();a=e.left,n=e.top}e.$.scrollView.style.setProperty("--smart-input-drop-down-menu-width",""),e.$.scrollView.style.left=-3+r.left+t-a+"px",e.$.scrollView.style.top=r.bottom+o-n+1+"px",e.$.scrollView.classList.remove("open"),e.opening=!0,e._positionTimer=setInterval((()=>{const t=e.getBoundingClientRect();if(e.opening)e.opening=!1,r=t;else if(t.top!==r.top||t.left!==r.left)return void e.close()}),50),e.$.scrollView.onpointerdown=function(){e._isPointerDown=!0},requestAnimationFrame((function(){const t=e.dropDownWidth;if(e.$.scrollView.refresh&&e.$.scrollView.refresh(),e._refreshMenu(),e.$.scrollView.setAttribute("open",""),e.setAttribute("open",""),e.$.dropDownButton.setAttribute("open",""),e.$.input.setAttribute("open",""),t&&"string"==typeof t&&-1!==t.indexOf("%")){const o=parseFloat(t)/100;e.$.scrollView.style.setProperty("--smart-input-drop-down-menu-width",e.offsetWidth*o+"px")}else if("auto"!==t&&t)e.$.scrollView.style.setProperty("--smart-input-drop-down-menu-width",parseFloat(t)+"px");else if("auto"===t){if(e.$.scrollView.style.setProperty("--smart-input-drop-down-menu-width",""),e.$.scrollView.$.scrollViewerContainer.classList.contains("vscroll")){const t=e.$.scrollView.offsetWidth+parseFloat(getComputedStyle(e.$.scrollView).getPropertyValue("--smart-scroll-bar-size"));e.$.scrollView.style.setProperty("--smart-input-drop-down-menu-width",t+"px")}}else{e.$.menu.style.width="auto";let t=e.$.menu.offsetWidth;const o=e.$.menu.querySelectorAll("li");for(let t=0;t<o.length;t++)e._maxDropDownWidth=Math.max((o[t].firstElementChild||o[t]).offsetWidth,e._maxDropDownWidth);e.$.scrollView.computedVerticalScrollBarVisibility&&(t+=e.$.scrollView.$&&e.$.scrollView.$.verticalScrollBar?e.$.scrollView.$.verticalScrollBar.offsetWidth:30),e.$.scrollView.style.setProperty("--smart-input-drop-down-menu-width",Math.max(t,e.offsetWidth-8)+"px"),e.$.menu.style.width=""}(e.shadowRoot||e.isInShadowDOM)&&e.$.scrollView._scrollView&&Smart.ScrollBar&&requestAnimationFrame((()=>{e.$.scrollView._scrollView&&e.$.scrollView._scrollView.vScrollBar.refresh()}))})),e.$.scrollView.refresh&&e.$.scrollView.refresh(),e._refreshMenu(),e.set("opened",!0),e.setAttribute("aria-expanded",!0),e.$.fireEvent("open")}close(){const e=this;return!!e.opened&&(e.timer&&clearTimeout(e.timer),e.timer=setTimeout((function(){e.$.scrollView.parentNode&&!e.opened&&(e.$.scrollView.remove(),e.removeAttribute("aria-owns"),e.readonly||e.$.input.removeAttribute("aria-controls"))}),1e3),e._positionTimer&&clearInterval(e._positionTimer),e.$.scrollView.removeAttribute("open"),e.$.dropDownButton.removeAttribute("open"),e.$.input.removeAttribute("open"),e.removeAttribute("open"),e.set("opened",!1),e.setAttribute("aria-expanded",!1),e.$.input.focus(),e.$.fireEvent("close"),!0)}refresh(){const e=this;e.$.scrollView.refresh&&e.$.scrollView.refresh(),e.close()}_lookup(e){const t=this;if(t.query=t.$.input.value,t.$.input.readonly&&(t._incrementalSearchQuery||(t._incrementalSearchQuery=""),t._incrementalSearchQuery+=e.key,t._incrementalSearchTimer&&clearTimeout(t._incrementalSearchTimer),t.query=t._incrementalSearchQuery,t._incrementalSearchTimer=setTimeout((function(){t._incrementalSearchQuery=""}),700)),t.query.length<t.minLength)return void t.close();const o=function(e){clearTimeout(t._autoCompleteTimeout),t._autoCompleteTimeout=setTimeout((()=>{const o=t.context;t.context=t,t._process(e),t.context=o}),t.autoCompleteDelay)};"function"==typeof t.dataSource?t.dataSource(t.query,o):o(t.dataSource)}_downHandler(e){const t=this;t.readonly&&t._dropDownButtonDownHandler(e)}_dropDownButtonDownHandler(e){const t=this;return"manual"!==t.dropDownOpenMode&&t._toggle(),e.preventDefault(),e.stopPropagation(),e.originalEvent.preventDefault(),e.originalEvent.stopPropagation(),t._isPointerDown=!0,!1}_toggle(){const e=this;e.opened?e.close():e.open()}open(){const e=this;function t(t){e._process(t);const o=e.$.menu.querySelector(".active");if(o){const t=e.$.input.dataValue;for(let r=0;r<e.$.menu.children.length;r++){const a=e.$.menu.children[r],n=a.getAttribute("data-label"),l=a.dataValue;if(void 0!==t&&l===t||void 0===t&&n===e.$.input.value){o.classList.remove("active"),a.classList.add("active"),e._setActiveDescendant(a),e.$.input.dataValue=l,e.setAttribute("data-value",l);break}}}e.ensureVisible(),e.$.input.focus(),setTimeout((function(){e.$.input.focus()}),25)}e.dropDownDataSource&&(Array.isArray(e.dropDownDataSource)&&e.dropDownDataSource.length>0||"function"==typeof e.dropDownDataSource)?(e.query="","function"==typeof e.dropDownDataSource?e.dropDownDataSource(e.query,t):t(e.dropDownDataSource)):(e.query="","function"==typeof e.dataSource?e.dataSource(e.query,t):t(e.dataSource))}_process(e){const t=this;"string"==typeof e&&(e=t.$.deserialize(e,"array")),e=e.filter((function(e){return""===e||(t.matcher?t.matcher(e):t._matcher(e))})),e=t._sorter(e),t.sorted&&(e.sort(((e,t)=>void 0!==e.label?e.label.localeCompare(t.label):e.localeCompare(t))),"desc"===t.sortDirection&&e.reverse()),!e.length&&t.opened&&t.close(),0!==e.length&&(t.query.length>0?t._render(e.slice(0,t.items)):t._render(e),t._open(),t.$.scrollView.refresh&&t.$.scrollView.refresh(),t._refreshMenu(),t.ensureVisible())}_matcher(e){const t=this.query;switch(null===e&&(e="null"),e=""+(e=e.label||e),this.queryMode){case"startsWith":return e.startsWith(t);case"startsWithIgnoreCase":return e.toLowerCase().startsWith(t.toLowerCase());case"doesNotContain":return e.indexOf(t)<0;case"doesNotContainIgnoreCase":return e.toLowerCase().indexOf(t.toLowerCase())<0;case"contains":return e.indexOf(t)>-1;default:case"containsIgnoreCase":return~e.toLowerCase().indexOf(t.toLowerCase());case"equals":return 0===e.localeCompare(t);case"equalsIgnoreCase":return 0===e.toLowerCase().localeCompare(t.toLowerCase());case"endsWith":return e.endsWith(t);case"endsWithIgnoreCase":return e.toLowerCase().endsWith(t.toLowerCase())}}_sorter(e){const t=this;let o,r=[],a=[],n=[];if(e&&""===e[0])return e;for(;o=e.shift();){let e=o.label||o;e=""+e,e.toLowerCase().indexOf(t.query.toLowerCase())?~e.indexOf(t.query)?a.push(o):n.push(o):r.push(o)}return r.concat(a,n)}_highlighter(e){const t=this.query.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g,"\\$&");return e.replace(new RegExp("("+t+")","ig"),(function(e,t){return"<strong>"+t+"</strong>"}))}_render(e){const t=this;let o=0;const r=e.map((function(e){let r=e,a=e;"object"==typeof e&&(r=e.label,a=void 0!==e.value?e.value:r),r=""+r;const n=document.createElement("li"),l=document.createElement("a");return l.href="#",n.id=t.id+"Item"+Math.floor(65536*(1+Math.random())).toString(16).substring(1),n.setAttribute("data-label",r),n.index=o++,n.dataValue=a,"string"==typeof a?n.setAttribute("value",a):n.setAttribute("value",JSON.stringify(a)),n.setAttribute("role","option"),n.setAttribute("aria-label",r),l.innerHTML=t.highlighter?t.highlighter(r):t._highlighter(r),l.setAttribute("aria-hidden",!0),e.icon&&(l.classList.add("icon"),l.classList.add(e.icon)),n.appendChild(l),n}));function a(){const e=t.$.menu.getElementsByClassName("active");e[0]&&e[0].classList.remove("active"),this.classList.add("active"),t._setActiveDescendant(this)}r.length>0&&(r[0].classList.add("active"),t._setActiveDescendant(r[0])),t.$.menu.innerHTML="";for(let e=0;e<r.length;e++){const o=r[e];t.$.menu.appendChild(o),o.onmouseenter=a,o.onmouseleave=function(){this.classList.remove("active"),t._setActiveDescendant(null)},o.onclick=a}}ensureVisible(){const e=this,t=e.$.menu.querySelector(".active");t&&(t.offsetTop+t.offsetHeight>=e.$.scrollView.scrollTop+e.$.scrollView.offsetHeight&&(e.$.scrollView.scrollTop=t.offsetTop+t.offsetHeight),(t.offsetTop<=e.$.scrollView.scrollTop||t.offsetTop>=e.$.scrollView.scrollTop+e.$.scrollView.offsetHeight)&&(e.$.scrollView.scrollTop=t.offsetTop),0===[...e.$.menu.children].indexOf(t)?e.$.scrollView.scrollTop=0:[...e.$.menu.children].indexOf(t)===e.$.menu.children.length-1&&(e.$.scrollView.scrollTop=e.$.scrollView.scrollHeight))}_next(){const e=this,t=e.$.menu.querySelector(".active");if(!t){const t=e.$.menu.firstElementChild;return t.classList.add("active"),void e._setActiveDescendant(t)}t.classList.remove("active");let o=t.nextElementSibling;o||(o=e.$.menu.firstElementChild),o.classList.add("active"),e._setActiveDescendant(o),e.ensureVisible()}_prev(){const e=this,t=e.$.menu.querySelector(".active");if(!t){const t=e.$.menu.firstElementChild;return t.classList.add("active"),void e._setActiveDescendant(t)}t.classList.remove("active");let o=t.previousElementSibling;o||(o=e.$.menu.lastElementChild),o.classList.add("active"),e._setActiveDescendant(o),e.ensureVisible()}_move(e){const t=this;if(t.opened){switch(e.keyCode){case 9:case 13:case 27:e.preventDefault();break;case 38:e.preventDefault(),t._prev();break;case 40:e.preventDefault(),t._next()}e.stopPropagation()}}_keyDownHandler(e){const t=this;t._suppressKeyPressRepeat=![40,38,9,13,27,16,17,18].includes(e.keyCode),t._oldValue=t.$.input.value,e.shiftKey||e.altKey||e.ctrlKey||t._move(e)}_keyPressHandler(e){this._suppressKeyPressRepeat||e.shiftKey||e.altKey||e.ctrlKey||this._move(e)}_keyUpHandler(e){const t=this;if(!e.shiftKey)switch(e.keyCode){case 40:case 38:case 16:case 17:case 18:40===e.keyCode&&e.altKey&&t.open(),38===e.keyCode&&e.altKey&&t.close();break;case 9:case 13:if(!t.opened)return;t._performSelect(),e.stopPropagation(),e.preventDefault();break;case 27:if(!t.opened)return;t.close(),e.stopPropagation(),e.preventDefault();break;default:t._lookup(e),!t.opened||e.ctrlKey||e.shiftKey||(e.stopPropagation(),e.preventDefault()),t.$.fireEvent("changing",{value:t.$.input.value,oldValue:t._oldValue}),t.$.input.dataValue=t.$.input.value,t.setAttribute("data-value",t.$.input.dataValue)}}propertyChangedHandler(e,t,o){super.propertyChangedHandler(e,t,o);const r=this;if("selectedIndex"===e)r._setSelection();else if("dropDownClassList"===e){const e=r.$.scrollView;for(let o=0,r=t.length;o<r;o+=1)e.classList.remove(t[o]);for(let t=0,r=o.length;t<r;t+=1)e.classList.add(o[t])}else if("dropDownHeight"===e)"auto"!==r.dropDownHeight?r.$.scrollView.style.setProperty("--smart-input-drop-down-menu-height",r.dropDownHeight+"px"):r.$.scrollView.style.setProperty("--smart-input-drop-down-menu-height","auto");else if("opened"===e)r.opened=t,o?r.open():r.close();else if("placeholder"===e){if(r.readonly){const e=r.getAttribute("aria-label");if(e&&e!==t)return;o?r.setAttribute("aria-label",o):r.removeAttribute("aria-label")}}else"value"===e?(r.displayMember!==r.valueMember&&"string"!=typeof o?(r.set("value",o[r.displayMember]),r.$.input.dataValue=o[r.valueMember],r.setAttribute("data-value",r.$.input.dataValue)):(r.$.input.value=r.$.input.dataValue=o,r.setAttribute("data-value",o)),r._refreshSelectedIndex()):"readonly"===e?(r._setAriaRelations(),r._setInputPurpose()):"theme"===e||"rightToLeft"===e?r.$.scrollView[e]=o:"inputPurpose"===e?r._setInputPurpose():"inverted"===e?o?r.$.scrollView.setAttribute("inverted",""):r.$.scrollView.removeAttribute("inverted"):"disabled"!==e&&"unfocusable"!==e||r._setFocusable()}detached(){super.detached(),this.close(),this.removeAttribute("focus")}render(){const e=this,t=e.dropDownClassList;e._createElement&&e._createElement();const o=e.$.scrollView;for(let e=0,r=t.length;e<r;e+=1)o.classList.add(t[e]);e.opened&&(e.opened=!1,e.open());const r=e.$.menu;r&&(r.setAttribute("role","presentation"),o.appendChild(r)),"auto"!==e.dropDownHeight?o.style.setProperty("--smart-input-drop-down-menu-height",e.dropDownHeight+"px"):o.style.setProperty("--smart-input-drop-down-menu-height","auto"),o.classList.add("smart-input-drop-down-menu"),o.id=e.id+"_"+e.tagName.toLowerCase()+"_menu_"+Math.floor(65536*(1+Math.random())).toString(16).substring(1),o.ownerElement=e,e._setAriaRelations(),e._setInputPurpose(),e._setSelection(),e.isInitialized=!0,super.render()}_setSelection(){const e=this;let t=e.dataSource;if("string"==typeof t&&(t=e.$.deserialize(t,"array")),e.selectedIndex>=0&&t&&t.length>0){let o=t[e.selectedIndex];if("number"!=typeof o&&"boolean"!=typeof o||(o=""+o),"string"==typeof o){let t=e.$.input.dataValue,r=e.value;e.set("value",o),e.$.input.dataValue=o,e.$.input.setAttribute("data-value",o),e.selectedValues=[e.$.input.dataValue],e.isInitialized&&e.$.fireEvent("change",{value:e.value,label:e.label,oldValue:t,oldLabel:r})}else{let t=e.$.input.dataValue,r=e.value;o.value?(e.set("value",void 0!==o.value?o.value+"":""),e.$.input.dataValue=o.value,e.$.input.setAttribute("data-value",o.value),e.selectedValues=[e.$.input.dataValue]):o.label&&(e.selectedValues=[o.value]),o.label&&e.set("value",o.label),e.isInitialized&&e.$.fireEvent("change",{value:e.$.input.dataValue,label:o.value,oldValue:t,oldLabel:r})}}}_createElement(){const e=this,t=document.createElement("ul"),o=document.createElement("smart-scroll-viewer");o.rightToLeft=e.rightToLeft,o.theme=e.theme,o.horizontalScrollBarVisibility="hidden",e.inverted?o.setAttribute("inverted",""):o.removeAttribute("inverted"),e.$.scrollView=o,e.$.menu=t,e._setFocusable(),e.$.menu.onclick=function(t){const o=t.target.closest("li");t.stopPropagation(),t.preventDefault(),e._performSelect(),o&&e.$.fireEvent("itemClick",{item:o,label:o.getAttribute("aria-label"),value:o.dataValue}),e.$.input.focus()}}_setAriaRelations(){const e=this,t=e.getAttribute("aria-label");e.readonly?(e.setAttribute("role","button"),!t&&e.placeholder&&e.setAttribute("aria-label",e.placeholder),e.removeAttribute("aria-readonly"),e.$.input.setAttribute("aria-hidden",!0),e.$.input.removeAttribute("aria-activedescendant"),e.$.input.removeAttribute("aria-controls"),e.$.dropDownButton.setAttribute("aria-hidden",!0)):(e.setAttribute("role","combobox"),t&&t===e.placeholder&&e.removeAttribute("aria-label"),e.$.input.setAttribute("role","searchbox"),e.$.input.removeAttribute("aria-hidden",!0),e.$.dropDownButton.removeAttribute("aria-hidden")),e.setAttribute("aria-expanded",e.opened),e.setAttribute("aria-haspopup","listbox"),e.setAttribute("aria-owns",e.$.scrollView.id),e.$.scrollView.setAttribute("role","listbox")}_setActiveDescendant(e){const t=this;t.readonly||(e?t.setAttribute("aria-activedescendant",e.id):t.removeAttribute("aria-activedescendant"))}_setInputPurpose(){const e=this;e.readonly?e.$.input.removeAttribute("autocomplete"):e.$.input.setAttribute("autocomplete",e.inputPurpose)}_setFocusable(){const e=this;e.disabled||e.unfocusable?e.$.input.setAttribute("tabindex",-1):e.$.input.removeAttribute("tabindex")}});