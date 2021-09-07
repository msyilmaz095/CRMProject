
/* Smart UI v9.4.16 (2021-07-17) 
Copyright (c) 2011-2021 jQWidgets. 
License: https://htmlelements.com/license/ */ //

Smart.Utilities.Assign("Grid.Filter",class{addFilter(e,t,l){const a=this,i=a.columnByDataField[e];if("string"==typeof t&&(t=a.dataSource._createFilter(i.dataType,[t])),i&&i.canNotify){if(i.setProperty("filter",t),a._isUpdating)return;!1!==l&&a.refreshFilters()}}removeFilter(e,t){const l=this,a=l.columnByDataField[e];if(a&&a.canNotify){if(a.setProperty("filter",null),l._isUpdating)return;!1!==t&&l.refreshFilters()}}clearFilter(){const e=this;for(let t=0;t<e.columns.length;t++)e.columns[t].setProperty("filter",null);e.refreshFilters()}getFilteredColumns(){const e=this;if(e._filters){const t=[];for(let l=0;l<e._filters.length;l++){const a=e._filters[l];t[a[0]]=a[1],t.length++}return t}return[]}getVisibleRows(){const e=this;if(e._visibleRows)return e._visibleRows;const t=[],l=e._viewRows,a=e.editing.addNewRow.visible&&"far"!==e.editing.addNewRow.position&&"button"!==e.editing.addNewRow.displayMode?1:0;for(let e=0;e<l.length;e++){const i=l[e];i.canNotify=!1,i.visibleIndex=-1,!i.visible||!1===i.filtered&&void 0!==i.filtered||(i.visibleIndex=t.length-a,t.push(i)),i.canNotify=!0}return e._visibleRows=t,t}refreshFilters(){const e=this,t=[];e._filters||(e._filters=[]);for(let l=0;l<e.columns.length;l++){const a=e.columns[l];a.filter&&t.push([a.dataField,a.filter])}if(e.scrollTop=0,e.closeMenu(),e.dataSource&&!e.dataSource.onFilter&&(e.dataSource.onFilter=function(){const t=e._viewRows;for(let e=0;e<t.length;e++){const l=t[e];if(l.data&&!l.addNewRow){if(!l.data.$){l.filtered=!1;continue}l.filtered=void 0===l.data.$.filtered||l.data.$.filtered}}e.refresh()}),JSON.stringify(e._filters)===JSON.stringify(t))return void(e._visibleRows=null);if(e._filters=t,e._visibleRows=null,e.dataSource&&e.dataSource.virtualDataSource)e.closeMenu(),e._virtualDataRequest("filter");else{const l=e._filterOperator||"and";e.dataSource._filter(t,l)}e.paging.enabled&&e.dataSource&&!e.dataSource.virtualDataSource&&e._refreshPagesCount();let l=[];for(let t=0;t<e.columns.length;t++){const a=e.columns[t];a.filter&&l.push(a)}let a=[];if(e._filters)for(let t=0;t<e._filters.length;t++){const l=e._filters[t];a.push({dataField:l[0],filter:l[1]})}e.$.fireEvent("filter",{columns:l,data:a})}_handleFilterCellFocus(e){const t=this,l=e.column._filterInfo,a=l.editor,i=l.input,n=e.column,r=n.dataType;a.setAttribute("focus",""),t.filtering.filterRow.cell=e,"RANGE"===l.condition?t._openFilterCellDialog(e,(e=>{const l=e._filterInfo,a=l.editor,i=l.range,n=l.input,r=l.cell;if(i){const l=new Smart.FilterGroup;l.addFilter("and",l.createFilter(e.dataType,i.min,"GREATER_THAN_OR_EQUAL")),l.addFilter("and",l.createFilter(e.dataType,i.max,"LESS_THAN_OR_EQUAL")),t.addFilter(e.dataField,l)}else t.removeFilter(e.dataField);if(a&&n)if(n.type="",i){const t=r.getFormattedValue(i.min,e.cellsFormat),l=r.getFormattedValue(i.max,e.cellsFormat);n.value=t+" - "+l}else n.value=""})):(i.type="number"===r||"int"===r||"float"===r?"number":"",l.value&&(i.value=l.value,"date"===r&&(i.value=e.getFormattedValue(l.value,n.cellsFormat))))}_handleFilterCellBlur(e){const t=this,l=e.column._filterInfo,a=l.editor,i=l.input,n=e.column,r=l.condition;t.filtering.filterRow.cell=null,n.filterRowMenu&&n.filterRowMenu.classList.contains("open")||(""!==i.value&&"RANGE"!==r&&("date"===n.dataType?(l.value=new Date(i.value),i.value=e.getFormattedValue(l.value,n.cellsFormat)):"number"===n.dataType||"int"===n.dataType||"float"===n.dataType?(l.value=parseFloat(i.value),i.type="",i.value=e.getFormattedValue(l.value,n.cellsFormat)):l.value=i.value),"auto"===t.filtering.filterRow.applyMode&&t._handleFilterCellValue(e)),a.removeAttribute("focus")}_handleFilterCellValue(e){const t=this,l=e.column._filterInfo,a=e.column;if("RANGE"===l.condition){const e=l.range;if(e){const l=new Smart.FilterGroup;l.addFilter("and",l.createFilter(a.dataType,e.min,"GREATER_THAN_OR_EQUAL")),l.addFilter("and",l.createFilter(a.dataType,e.max,"LESS_THAN_OR_EQUAL")),t.addFilter(a.dataField,l)}else t.removeFilter(a.dataField)}else{const e=l.value;if(""!==e&&void 0!==e){const i=new Smart.FilterGroup;i.addFilter("and",i.createFilter(a.dataType,e,l.condition||("string"===a.dataType?"CONTAINS":"EQUAL"))),t.addFilter(a.dataField,i)}else t.removeFilter(a.dataField)}}_handleFilterCellKeyDown(e,t){const l=this,a=e.column._filterInfo.input;t.ctrlKey&&"a"===t.key?a.select():t.altKey&&"ArrowDown"===t.key&&l._handleFilterCellIconClick(e)}_handleFilterCellKeyUp(e,t){const l=e.column,a=l._filterInfo.input,i=this,n=l._filterInfo,r=t.key;n.value=a.value,"Escape"===r&&(n.value="",n.range=null,a.value=""),"Enter"===r||"Escape"===r||""===a.value?i._handleFilterCellValue(e):"auto"===i.filtering.filterRow.applyMode&&"Ctrl"!==r&&"Shift"!==r&&(i._filterRowTimer&&clearTimeout(i._filterRowTimer),i._filterRowTimer=setTimeout((()=>{i._handleFilterCellValue(e)}),i.filtering.filterRow.autoApplyModeDelay)),t.ctrlKey&&"a"===r&&a.select()}_handleFilterCellCheckBoxClick(e){const t=this,l=e.column,a=l._filterInfo;void 0===a.value&&(a.value=null),!0===a.value?a.value=!1:!1===a.value?a.value=null:null===a.value&&(a.value=!0);const i=e.element.querySelector(".smart-input");if(a.value?i.setAttribute("checked",a.value):null===a.value?i.setAttribute("checked","indeterminate"):i.removeAttribute("checked"),null===a.value)return void t.removeFilter(l.dataField);const n=new Smart.FilterGroup;n.addFilter("and",n.createFilter(l.dataType,!0===a.value,"EQUAL")),t.addFilter(l.dataField,n)}_handleFilterCellIconClick(e){const t=this,l=e.column;l.filterRowMenu&&l.filterRowMenu.classList.contains("open")?t._closeMenu(l.filterRowMenu):t._openColumnFilterMenu(l)}_handleFilterCalendarCellClick(e){const t=this;t._openFilterCellDialog(e,(l=>{const a=l._filterInfo,i=a.editor.querySelector("input"),n=a.value;if(i)if(n){i.value=e.getFormattedValue(n,l.cellsFormat||"");const r=new Smart.FilterGroup;r.addFilter("and",r.createFilter(l.dataType,n,a.condition||"EQUAL")),t.addFilter(l.dataField,r)}else i.value="",t.removeFilter(l.dataField)}))}_handleFilterMenuClick(e,t){const l=this,a=e._filterInfo,i=a.editor,n=a.input;if(i.firstElementChild.innerHTML=`<i class="smart-grid-icon ${t.icon} show"></i>`,"CLEAR_FILTER"===t.value&&(n.value="",i.firstElementChild.innerHTML='<i class="smart-grid-icon smart-icon-search show"></i>',a.condition=null,a.value="",a.range=null),n.type="","RANGE"===a.condition&&"RANGE"!==t.value){let e=a.range;a.value=e.min}else if("RANGE"===t.value&&"RANGE"!==a.condition&&null!==a.condition){let e=a.range;a.value&&(e={min:a.value,max:a.value},a.range=e)}if("RANGE"!==t.value){if(n.readonly=!1,"CLEAR_FILTER"!==t.value&&(a.condition=t.value),""===n.value)l.removeFilter(e.dataField);else{const t=new Smart.FilterGroup,i=a.value;t.addFilter("and",t.createFilter(e.dataType,i,a.condition||"EQUAL")),l.addFilter(e.dataField,t),n.value=a.cell.getFormattedValue(i,e.cellsFormat)}setTimeout((()=>{n.focus()}),25)}else{n.readonly=!0;const i=new Smart.FilterGroup,r=a.range;if(r){i.addFilter("and",i.createFilter(e.dataType,r.min,"GREATER_THAN_OR_EQUAL")),i.addFilter("and",i.createFilter(e.dataType,r.max,"LESS_THAN_OR_EQUAL")),l.addFilter(e.dataField,i);const t=a.cell.getFormattedValue(r.min,e.cellsFormat),o=a.cell.getFormattedValue(r.max,e.cellsFormat);n.value=t+" - "+o}else n.value="";a.condition=t.value}}_handleFilterNumberCellEditor(e,t,l){const a=t.querySelector("input"),i=t.querySelector(".up"),n=t.querySelector(".down"),r=e.column,o=this;let d=t=>{const l=r._filterInfo;if("RANGE"===l.condition)return void a.focus();let i=parseFloat(l.value);if(isNaN(i))return l.value=0,void(a.value=0);(t<0?i>a.min||""===a.min:i<a.max||""===a.max)&&(a.value=i+t,l.value=a.value,a.focus(),o._handleFilterCellValue(e))};l&&(d=l);const c=(e,t)=>{let l,a;e.onpointerdown=function(e){d(t),l&&clearTimeout(l),l=setTimeout((()=>{a&&clearInterval(a),a=setInterval((()=>{d(t)}),50)}),300),e.preventDefault(),e.stopPropagation()},e.onpointerup=()=>{a&&clearInterval(a),l&&clearTimeout(l),a=null},e.onpointerenter=()=>{a&&(clearInterval(a),a=setInterval((()=>{d(1)}),50))},e.onpointerleave=()=>{clearInterval(a)},document.addEventListener("pointerup",(()=>{a&&clearInterval(a),a=null,l&&clearTimeout(l)}))};c(i,1),c(n,-1)}_openFilterCellDialog(e,t){const l=this,a=l._dialogFilter||l._createDialog(),i=l.localize("dialogFilterHeader")+" "+e.column.label,n=a.content;a.header.innerHTML=i,a.confirm=t;let r=null,o=0;l._cellEditors||(l._cellEditors=[]),l._dialogFilter||(a.modal=!0,a.btnConfirm.innerHTML=l.localize("dialogFilterButtonConfirm"),a.btnCancel.innerHTML=l.localize("dialogFilterButtonCancel"),a.onOpen=function(){a.focus();const e=l._dialogFilterCell,t=e.column._filterInfo.range,i=e.column._filterInfo.value;if("date"===e.column.dataType){const a=n.querySelector("smart-calendar");a.locale=l.locale,setTimeout((()=>{"RANGE"===e.column._filterInfo.condition&&t?(a.selectedDates=[new Date(t.min.getTime()),new Date(t.max.getTime())],a._selectMultipleDates(new Date(t.min.getTime()),new Date(t.max.getTime()))):i&&(a.selectedDates=[new Date(i.getTime())]),a.focus()}),100),a.focus()}else{const e=n.querySelectorAll("input");e[0].focus(),t&&(e[0].value=t.min,e[1].value=t.max)}},a.onClose=function(){},a.btnCancel.onclick=function(){a.close();const e=l._dialogFilterCell;e.column._filterInfo.range=null,e.column._filterInfo.value=null,a.confirm(e.column)},a.btnClose.onclick=function(){a.close()},a.btnConfirm.onclick=function(){const e=l._dialogFilterCell;if(e.column._filterInfo.range=null,e.column._filterInfo.value=null,"date"===e.column.dataType){const t=n.querySelector("smart-calendar"),l=t.selectedDates;"range"===t.selectionMode?e.column._filterInfo.range={min:new Date(l[0].getTime()),max:new Date(l[l.length-1].getTime())}:e.column._filterInfo.value=new Date(l[0].getTime())}else{const t=n.querySelectorAll("input");let l=t[0].value,a=t[1].value;""===a&&(a=100),""===l&&(l=0),e.column._filterInfo.range={min:l,max:a}}a.confirm(e.column),a.close()},a.onkeydown=function(e){const t=e.key;"Enter"===t?a.btnConfirm.onclick():"Escape"===t&&a.close()}),n.classList.remove("smart-grid-layout"),n.innerHTML="";const d=()=>{const e=n.querySelectorAll("input");a.btnConfirm.disabled=!0,""===e[0].value&&(e[0].value=0),""===e[1].value&&(e[1].value=100),parseFloat(e[0].value)<=parseFloat(e[1].value)&&(a.btnConfirm.disabled=!1)};"date"!==e.column.dataType&&n.classList.add("smart-grid-layout");for(let t=0;t<2;t++){const a=e.column;if("date"===a.dataType){const e=document.createElement("div");"RANGE"===a._filterInfo.condition?e.innerHTML='<smart-calendar selection-mode="range"></smart-calendar>':e.innerHTML="<smart-calendar></smart-calendar>",n.appendChild(e);break}o%2==0&&(r=document.createElement("div"),r.classList.add("row"),n.appendChild(r));const i=document.createElement("div");i.classList.add("col-sm-6");const c=document.createElement("div");c.classList.add("column");const u=document.createElement("label");u.innerHTML=0===t?l.localize("dialogFilterMinLabel"):l.localize("dialogFilterMaxLabel");const s=document.createElement("div");s.classList.add("smart-grid-dialog-editor"),s.setAttribute("editor",a.dataField),s.setAttribute("template",a.editor.template),i.appendChild(c),r.appendChild(i),c.appendChild(u),c.appendChild(s),o++,s.innerHTML='<div class="smart-grid-cell-editor smart-filter-input-value smart-grid-number-input-cell-editor"><input class="smart-input" type="number"><div class="nav"><div tabindex="-1" class="up"></div><div tabindex="-1" class="down"></div></div></div>';const m=s.querySelector("input");m.onchange=()=>{d()},l._handleFilterNumberCellEditor(e,s,(e=>{let t=parseFloat(m.value);isNaN(t)?m.value=0:((e<0?t>m.min||""===m.min:t<m.max||""===m.max)&&(m.value=t+e),d())}))}l._dialogFilter=a,l._dialogFilterCell=e;const c=e.column.element.getBoundingClientRect(),u=l.offset(l);let s=c.left+window.pageXOffset-u.left,m=c.bottom+l.layout.rowMinHeight+window.pageYOffset-u.top;a.open(s,m)}});