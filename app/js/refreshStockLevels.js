// Custom JavaScript function to refresh the StockLevels data view
function refreshStockLevels() {
    var stockLevelsView = $app.find('StockLevels');
    if (stockLevelsView) {
        stockLevelsView.refresh();
    }
}
