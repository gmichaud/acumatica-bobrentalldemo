Sizzle.selectors.filters.containsRegexp = function (elem, i, match) { 
	var regexp = new RegExp(match[3]); return regexp.test((elem.textContent || elem.innerText || Sizzle.getText([ elem ]) || "")) ;
}

Sizzle.selectors.filters.textEqual = function (elem, i, match) { 
	return (elem.textContent || elem.innerText || Sizzle.getText([ elem ]) || "") == match[3];
}

Sizzle.selectors.filters.visible = function(elem) {
	return elem.offsetWidth > 0 && elem.offsetHeight > 0;
}