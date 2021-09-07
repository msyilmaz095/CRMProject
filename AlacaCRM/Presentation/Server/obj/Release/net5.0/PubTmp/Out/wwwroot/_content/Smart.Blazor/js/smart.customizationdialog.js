
/* Smart UI v9.1.39 (2021-03-05) 
Copyright (c) 2011-2021 jQWidgets. 
License: https://htmlelements.com/license/ */ //

!function(e){var t={};function l(n){if(t[n])return t[n].exports;var o=t[n]={i:n,l:!1,exports:{}};return e[n].call(o.exports,o,o.exports,l),o.l=!0,o.exports}l.m=e,l.c=t,l.d=function(e,t,n){l.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:n})},l.r=function(e){"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},l.t=function(e,t){if(1&t&&(e=l(e)),8&t)return e;if(4&t&&"object"==typeof e&&e&&e.__esModule)return e;var n=Object.create(null);if(l.r(n),Object.defineProperty(n,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var o in e)l.d(n,o,function(t){return e[t]}.bind(null,o));return n},l.n=function(e){var t=e&&e.__esModule?function(){return e.default}:function(){return e};return l.d(t,"a",t),t},l.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},l.p="",l(l.s=26)}({26:function(e,t){Smart("smart-customization-dialog",class extends Smart.TabsWindow{static get properties(){return{dataSource:{value:null,type:"any",reflectToAttribute:!1},displayMember:{value:"",type:"string"},filtering:{value:!1,type:"boolean"},grouping:{value:!1,type:"boolean"},headerButtons:{value:["apply","close"],type:"array",reflectToAttribute:!1},messages:{value:{en:{sorting:"SORTING",grouping:"GROUPING",filtering:"FILTERING",columnChooser:"COLUMN CHOOSER",applyButton:"Apply",closeButton:"Close",columnsToSort:"Columns to Sort",columnsToGroup:"Columns to Group",placeholderSorting:"No sorting applied",placeholderGrouping:"No grouping applied",and:"And",notand:"Not And",or:"Or",notor:"Not Or","=":"Equals","<>":"Does not equal",">":"Greater than",">=":"Greater than or equal to","<":"Less than","<=":"Less than or equal to",startswith:"Starts with",endswith:"Ends with",contains:"Contains",notcontains:"Does not contain",isblank:"Is blank",isnotblank:"Is not blank"}},type:"object",extend:!0},modal:{value:!0,type:"boolean",reflectToAttribute:!1},pinned:{value:!0,type:"boolean",reflectToAttribute:!1},reorder:{value:!1,type:"boolean"},selectedTab:{value:0,type:"int"},sorting:{value:!1,type:"boolean"},value:{value:null,type:"object",reflectToAttribute:!1},valueMember:{value:"",type:"string"},visibility:{value:!1,type:"boolean"}}}static get listeners(){return{down:"_findАctiveListBox","document.scroll":"_handleScroll",resize:"_updateElementHeight","applyButton.click":"close","closeButton.click":"close","tabsElement.change":"_handleChange","tabsElement.dragStart":"_reorderStartHandler","tabsElement.dragEnd":"_reorderEndHandler","tabsElement.click":"_handleClickOnDynamicNodes","filteringDropDown.change":"_handleFilteringDropDownChange","sortingToggleElement.click":"_handleToggleElementClick","groupingToggleElement.click":"_handleToggleElementClick","allColumnsChooser.down":"_preventDragOnListItem","allColumnsChooser.up":"_preventDragOnListItem","selectedColumnsSorting.down":"_preventDragOnListItem","selectedColumnsSorting.up":"_preventDragOnListItem","selectedColumnsGrouping.down":"_preventDragOnListItem","selectedColumnsGrouping.up":"_preventDragOnListItem",transitionend:"_handleTransitionEnd"}}template(){return'<div id="container">\n                    <div id="headerSection" class="smart-header-section">\n                        <div id="header" class="smart-header">[[label]]</div>\n                        <div id="buttonsContainer" class="smart-buttons-container">\n                            <smart-button id="closeButton" class ="smart-close-button" theme="[[theme]]"></smart-button>\n                            <smart-button id="applyButton" disabled class ="smart-apply-button" theme="[[theme]]"></smart-button>\n                        </div>\n                    </div>\n                    <div id="contentSection" class="smart-content">\n                       <smart-tabs id="tabsElement" selected-index="[[selectedTab]]" animation="[[animation]]" theme="[[theme]]">\n                            <smart-tab-item>\n                                <div id="placeholderSorting" class ="placeholder"></div>\n                                <div id="selectedColumnsSortingContainer" class ="selected-columns sortable container">\n                                    <smart-list-box id="selectedColumnsSorting" class ="smart-selected-columns-sorting" selection-mode="none" allow-drag allow-drop placeholder=""></smart-list-box>\n                                </div>\n                                <div id="allColumnsSortingContainer" class ="all-columns sortable container">\n                                    <div class ="toggle-element" id="sortingToggleElement"></div>\n                                    <div id="columnsToSort" class ="header-text"></div>\n                                    <smart-list-box id="allColumnsSorting" class ="smart-all-columns-sorting"  placeholder="" selection-mode="checkBox"></smart-list-box>\n                                </div>\n                            </smart-tab-item>\n                            <smart-tab-item>\n                                <div id="placeholderGrouping" class="placeholder"></div>\n                                <div  id="selectedColumnsGroupingContainer" class ="selected-columns sortable container">\n                                    <smart-list-box id="selectedColumnsGrouping" class ="smart-selected-columns-grouping" selection-mode="none" allow-drag allow-drop placeholder=""></smart-list-box>\n                                </div>\n                                <div  id="allColumnsGroupingContainer" class ="all-columns sortable container">\n                                    <div class ="toggle-element" id="groupingToggleElement"></div>\n                                    <div id="columnsToGroup" class ="header-text"></div>\n                                    <smart-list-box id="allColumnsGrouping" class ="smart-all-columns-grouping"  placeholder="" selection-mode="checkBox"></smart-list-box>\n                                </div>\n                            </smart-tab-item>\n                            <smart-tab-item>\n                                <smart-accordion id="allColumnsFiltering" placeholder="" expand-mode="multiple" tabindex="1"></smart-accordion>\n                            </smart-tab-item>\n                            <smart-tab-item>\n                                <smart-list-box id="allColumnsChooser" class ="smart-all-columns-chooser" placeholder="" allow-drag allow-drop selection-mode="checkBox"></smart-list-box>\n                            </smart-tab-item>\n                        </smart-tabs>\n                    </div>\n                    <smart-drop-down-list id="filteringDropDown" drop-down-append-to="body" drop-down-width="auto" drop-down-height="auto" animation="[[animation]]" theme="[[theme]]" class ="smart-filtering-drop-down"></smart-drop-down-list>\n                </div>'}static get requires(){return{"Smart.TabsWindow":"smart.window.js","Smart.Accordion":"smart.accordion.js","Smart.DropDownList":"smart.dropdownlist.js"}}propertyChangedHandler(e,t,l){const n=this;switch(e){case"valueMember":case"displayMember":case"dataSource":n._mapDataSource(n.dataSource,n.valueMember,n.displayMember),n._applyValue(n.value),n._handlePlaceholderAndContainer(),n.$.applyButton.disabled=!0;break;case"value":n._applyValue(l),n._handlePlaceholderAndContainer();break;case"locale":case"messages":n._applyMessages();break;case"sorting":case"grouping":case"filtering":case"reorder":case"visibility":n._toggleCustomizationOptions();break;case"theme":case"animation":n._applyBindings()}}ready(){this.$.addClass("smart-hidden"),super.ready(),this._applyBindings(),this._mapDataSource(this.dataSource,this.valueMember,this.displayMember),this._applyValue(this.value),this._applyMessages(),this._toggleCustomizationOptions(),this._randomId=Math.floor(1e5*Math.random()),this._applyListboxTemplates(),this._handlePlaceholderAndContainer(),this.$.removeClass("smart-hidden")}open(){const e=this;super.open(),e._resizeListBoxContainers(),e._updateElementHeight(),"none"!==e.animation&&(e._resizeAtAnimationEnd=!0,[e.$.sortingToggleElement,e.$.groupingToggleElement].forEach(t=>e._toggleGroup(t))),e.$.applyButton.disabled=!0}_applyListboxTemplates(){[{listbox:this.$.selectedColumnsSorting,prefix:"sortingTemplate",template:'<span class="smart-drag-area"></span>\n                        <span class="smart-label">{{label}}</span>\n                        <span class="smart-close-item-button"></span>\n                        <smart-check-box class ="smart-sort-button"></smart-check-box>'},{listbox:this.$.selectedColumnsGrouping,prefix:"groupingTemplate",template:'<span class="smart-drag-area"></span>\n                        <span class="smart-label">{{label}}</span>\n                        <span class="smart-close-item-button"></span>'},{listbox:this.$.allColumnsChooser,prefix:"columnChooserTemplate",template:'<span class="smart-drag-area"></span>\n                        <span class="smart-label">{{label}}</span>'}].forEach(e=>{const t=document.createElement("template"),l=e.prefix+this._randomId;t.innerHTML=e.template,t.id=l,this.appendChild(t),e.listbox.itemTemplate=l})}_applyBindings(){const e=this,t=["theme","animation"];["selectedColumnsSorting","allColumnsSorting","selectedColumnsGrouping","allColumnsGrouping","allColumnsFiltering","allColumnsChooser"].forEach(l=>t.forEach(t=>e.$[l][t]=e[t]))}_applyMessages(){const e=this;["sorting","grouping","filtering","columnChooser"].forEach((t,l)=>e.$.tabsElement.update(l,e.localize(t))),["closeButton","applyButton"].forEach(t=>e.$[t].title=e.localize(t)),["columnsToSort","columnsToGroup","placeholderSorting","placeholderGrouping"].forEach(t=>e.$[t].innerText=e.localize(t))}_applyValue(e){const t=this;if((e=t._validateValue(e)).order&&e.order.length>0){const l=t._reorderDataSource(e.order);t.$.allColumnsSorting.dataSource=l,t.$.allColumnsGrouping.dataSource=l,t.$.allColumnsChooser.dataSource=l}t.$.selectedColumnsSorting.items.forEach(t=>{const l=t.getElementsByTagName("smart-check-box")[0],n=e.sorting.find((function(e){return e.field===t.value}));t.hidden=!n,l.checked=!(!n||"desc"!==n.sortDirection)}),t.$.allColumnsSorting.selectedValues=[],e.sorting.forEach(e=>{e.field&&t.$.allColumnsSorting.select(e.field)}),e.grouping&&e.grouping.length>0?(t.$.selectedColumnsGrouping.items.forEach(t=>t.hidden=!(e.grouping.indexOf(t.value)>-1)),t.$.allColumnsGrouping.selectedValues=[],e.grouping.forEach(e=>t.$.allColumnsGrouping.select(e)),t.$.selectedColumnsSorting.items.forEach(t=>{e.grouping.indexOf(t.value)>-1&&(t.hidden=!1,t.disabled=!0)}),t.$.allColumnsSorting.items.forEach(t=>t.disabled=e.grouping.indexOf(t.value)>-1)):t.$.selectedColumnsGrouping.items.forEach(e=>e.hidden=!0),t.$.allColumnsChooser.selectedValues=e.hidden,t._toggleBothPlaceholders(),t._populateFilterSection()}_getValueFromState(e){const t=this,l=JSON.parse(JSON.stringify(t.value)),n={},o=[];n.sorting=t.$.selectedColumnsSorting.items.reduce((e,t)=>{const l=t.getElementsByTagName("smart-check-box")[0];return!t.hidden&&e.push({field:t.value,sortDirection:l.checked?"desc":"asc"}),e},[]),n.grouping=t.$.selectedColumnsGrouping.items.reduce((e,t)=>(!t.hidden&&e.push(t.value),e),[]),n.order=t.$.allColumnsChooser.items.map(e=>e.value),n.hidden=t.$.allColumnsChooser.selectedValues;for(let e in t._filteringDetails){const l=t._filteringDetails[e],n={field:e,criteria:l.accordionItem.data.criteria,pattern:l.input.value};o.push(n)}n.filtering=o,t.value=n,e||t.$.fireEvent("change",{value:t.value,oldValue:l,type:"customizationdialog"}),t.$.applyButton.disabled=!1}_handleChange(e){const t=this,l=e.detail,n=l?l.value:"",o=e.target.closest("smart-list-box"),a=e.target.closest("input"),s=e.target.closest("smart-accordion-item");e.target===t.$.tabsElement?(t._resizeListBoxContainers(),t._updateElementHeight()):s&&a?(t.$.applyButton.disabled=!1,t._getValueFromState()):o&&t._handleListBoxSelectionChanges(o,n,l)}_handleClickOnDynamicNodes(e){const t=e.target.closest(".smart-close-item-button"),l=e.target.closest(".smart-filter-options-container-text");(t||l)&&(t?this._handleClickOnCloseButton(t):this._handleClickOnFilterOption(l))}_handleClickOnCloseButton(e){const t=this,l=e.closest("smart-list-item"),n=l.value,o=l.closest("smart-list-box");function a(e){const t=e.selectedValues.slice();t.splice(t.indexOf(n),1),e.selectedValues=t}l.hidden=!0,o===t.$.selectedColumnsSorting?(a(t.$.allColumnsSorting),t._toggleGroup(t.$.sortingToggleElement)):o===t.$.selectedColumnsGrouping&&(a(t.$.allColumnsGrouping),t._updateListBoxItem(t.$.selectedColumnsSorting,n,{disabled:!1,hidden:!0,selected:!1}),t._updateListBoxItem(t.$.allColumnsSorting,n,{disabled:!1,selected:!1}),t._toggleGroup(t.$.groupingToggleElement)),t._getValueFromState()}_handleClickOnFilterOption(e){const t=this,l=e.closest("smart-accordion-item");t._filterLabelContainer&&t._filterLabelContainer===e||(e.closest(".smart-filter-options-container").appendChild(t.$.filteringDropDown),t.$.filteringDropDown.dataSource=l.data.options,t._filterLabelContainer=e);const n=t.$.filteringDropDown.items.find(e=>e.value===l.data.criteria);n&&(t.$.filteringDropDown.select(n),t.$.filteringDropDown.ensureVisible(n)),setTimeout((function(){t.$.filteringDropDown.open(),t.$.filteringDropDown.focus()}),0)}_handleFilteringDropDownChange(e){const t=e.detail;if(!this._filterLabelContainer)return;const l=this._filterLabelContainer.closest("smart-accordion-item");this.$.filteringDropDown.closest("smart-accordion-item")===l&&(this._filterLabelContainer.innerText=t.label,l.data.criteria=t.value,this.$.applyButton.disabled=!1,this._getValueFromState())}_handleListBoxSelectionChanges(e,t,l){const n=this;if(n._activeListBox===e){switch(e){case n.$.allColumnsSorting:n._updateListBoxItem(n.$.selectedColumnsSorting,t,{hidden:!l.selected}),n._toggleGroup(n.$.sortingToggleElement);break;case n.$.allColumnsGrouping:n._updateListBoxItem(n.$.selectedColumnsGrouping,t,{hidden:!l.selected}),n._updateListBoxItem(n.$.selectedColumnsSorting,t,{disabled:l.selected,hidden:!l.selected}),n._updateListBoxItem(n.$.allColumnsSorting,t,{disabled:l.selected,selected:l.selected}),n._toggleGroup(n.$.groupingToggleElement)}n._getValueFromState(),n._toggleRequired=!0}}_handleToggleElementClick(e){const t=e.target.closest(".toggle-element");t&&(t.classList.remove("smart-active"),t===this.$.sortingToggleElement?this._updateListHeight(this.$.selectedColumnsSorting):this._updateListHeight(this.$.selectedColumnsGrouping),this._updateElementHeight(),"none"!==this.animation&&(this._resizeAtAnimationEnd=!0))}_mapDataSource(e,t,l){const n=this,o=["selectedColumnsSorting","allColumnsSorting","selectedColumnsGrouping","allColumnsGrouping","allColumnsChooser"];t=t&&t.length>0?t:"value",l=l&&l.length>0?l:"label";for(let a=0;a<o.length;a++){const s=o[a],i=n.$[s];i.dataSource=e||[],i.valueMember=t,i.displayMember=l}}_populateFilterSection(){const e=this;if(!e.dataSource||0===e.dataSource.length)return;const t=e._validateValue(e.value),l=t.order.length>0?e._reorderDataSource(t.order):e.dataSource,n=t.filtering,o=["=","<>",">",">=","<","<=","startswith","endswith","contains","notcontains","isblank","isnotblank"];e.$.allColumnsFiltering.$.container.innerHTML="",e._filteringDetails={};for(let t=0;t<l.length;t++){const a=document.createElement("smart-accordion-item"),s=document.createElement("input"),i=document.createElement("div"),r=document.createElement("span"),d=l[t],c=d.filteringOptions,u=(c||o).map(t=>({value:t,label:e.localize(t)}));let m=n.find((function(t){return t.field===d[e.valueMember]}));a.data=void 0===m?{options:u,field:d,criteria:c?c[0]:"contains",pattern:""}:{options:u,field:m.field,criteria:m.criteria||c[0]||"contains",pattern:m.pattern||""},a.label=d[e.displayMember],e.$.allColumnsFiltering.appendChild(a),s.className="smart-filter-input",s.name=a.data.field,s.value=a.data.pattern,i.className="smart-filter-options-container",i.label=e.localize(a.data.criteria),r.className="smart-filter-options-container-text",r.innerText=e.localize(a.data.criteria||"contains"),i.appendChild(r),a.$.contentContainer.appendChild(i),a.$.contentContainer.appendChild(s),e._filteringDetails[d[e.valueMember]]={input:s,accordionItem:a,dropDownContainer:i}}}_reorderDataSource(e){const t=this;if(0===(e=e||[]).length||!t.dataSource||0===t.dataSource.length)return t.dataSource;let l=[],n=t.dataSource.slice();return e.forEach(e=>{const o=n.find(l=>e===l[t.valueMember]);l.push(o),n.splice(n.indexOf(o),1)}),n.forEach(e=>l.push(e)),l}_reorderEndHandler(e){const t=this,l=e.target.closest("smart-list-box");if(l.$.removeClass("smart-is-in-reorder"),l===t.$.allColumnsChooser&&t._allColumnsReorder){const e=t.$.allColumnsChooser.items.map(e=>e.value),l=t._reorderDataSource(e),n=t.$.allColumnsSorting.selectedValues,o=t.$.allColumnsGrouping.selectedValues;t.$.allColumnsSorting.dataSource=l,t.$.allColumnsSorting.items.map(e=>{o&&o.includes(e.value)&&(e.disabled=!0)}),n.forEach(e=>t.$.allColumnsSorting.select(e)),t.$.allColumnsGrouping.dataSource=l,o.forEach(e=>t.$.allColumnsGrouping.select(e)),t._populateFilterSection(),t._allColumnsReorder=!1}t._getValueFromState()}_reorderStartHandler(e){const t=this,l=e.target.closest("smart-list-box");l&&(Smart.ListBox.DragDrop.Feedback&&Smart.ListBox.DragDrop.Feedback.classList.add("smart-customization-dialog"),l.allowDrop=!e.detail.target.closest(".smart-input"),t._getValueFromState(!0),l.$.addClass("smart-is-in-reorder"),l===t.$.allColumnsChooser&&(t._allColumnsReorder=!0))}_resizeListBoxContainers(){this.$.sortingToggleElement.classList.remove("smart-active"),this.$.groupingToggleElement.classList.remove("smart-active"),this._updateListHeight(this.$.selectedColumnsSorting),this._updateListHeight(this.$.selectedColumnsGrouping)}_toggleBothPlaceholders(){const e=this.$.selectedColumnsSorting.items.find(e=>!e.hidden),t=this.$.selectedColumnsGrouping.items.find(e=>!e.hidden);e?this.$.placeholderSorting.classList.add("smart-hidden"):this.$.placeholderSorting.classList.remove("smart-hidden"),t?this.$.placeholderGrouping.classList.add("smart-hidden"):this.$.placeholderGrouping.classList.remove("smart-hidden")}_toggleCustomizationOptions(){const e=this,t=e.$.tabsElement._tabs;t[0].disabled=!e.sorting,t[1].disabled=!e.grouping,t[2].disabled=!e.filtering,e.reorder||e.visibility?(t[3].disabled=!1,e.$.allColumnsChooser.allowDrag=e.$.allColumnsChooser.allowDrop=e.reorder,e.$.allColumnsChooser.selectionMode=e.visibility?"checkBox":"none"):t[3].disabled=!0}_toggleGroup(e){const t=e.closest("smart-tab-item").getElementsByClassName("selected-columns")[0];e.classList.add("smart-active"),t.offsetHeight<t.scrollHeight?e.classList.add("smart-down"):e.classList.remove("smart-down"),this._toggleBothPlaceholders(),this.$.applyButton.disabled=!1}_updateElementHeight(){const e=this;if(e.style.height)return void(e.style.minHeight=e.style.height);const t=e.$.headerSection.getBoundingClientRect().height,l=e.$.tabsElement.$.tabsHeaderSection.getBoundingClientRect().height,n=e.$.tabsElement.selectedIndex;e.style.minHeight="0px",e.style.minHeight=e.$.tabsElement._tabs[n].scrollHeight+t+l+"px"}_updateListBoxItem(e,t,l){const n=e.items.find(e=>e.value===t);n&&l&&0!==l.length&&e.update(n.dataIndex,l)}_updateListHeight(e){const t=e.getBoundingClientRect().height;e.parentNode.style.height=t+"px"}_validateValue(e){let t=e||{};return["sorting","grouping","filtering","order","hidden"].forEach(e=>t[e]=t[e]||[]),t}_headerDblCickHandler(){}_handleScroll(e){this.opened&&this._toggleRequired&&("none"!==this.animation&&(this._resizeAtAnimationEnd=!0),this._handlePlaceholderAndContainer(),this._updateElementHeight(),this._toggleRequired=!1)}_preventDragOnListItem(e){const t=this,l=e.target.closest("smart-list-box");"down"===e.type&&["smart-close-item-button","smart-sort-button","smart-input"].indexOf(e.originalEvent.target.className)>-1?(l.allowDrag=l.allowDrop=!0,t._selectedListBox=l,Smart.ListBox.DragDrop.Feedback&&Smart.ListBox.DragDrop.Feedback.classList.add("smart-hidden")):t._selectedListBox&&!t._selectedListBox.allowDrag&&(t._selectedListBox.allowDrag=t._selectedListBox.allowDrop=!0)}_handleTransitionEnd(e){(this._resizeAtAnimationEnd||"height"===e.propertyName)&&(this._resizeAtAnimationEnd=!1,this._resizeListBoxContainers(),this._updateElementHeight())}_handlePlaceholderAndContainer(){this._toggleBothPlaceholders(),this._resizeListBoxContainers(),this._updateElementHeight()}"_findАctiveListBox"(e){this._activeListBox=e&&e.originalEvent&&e.originalEvent.target.closest("smart-list-box")}})}});