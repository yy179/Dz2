CREATE FUNCTION CalculateDiscount( @purchase_amount DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @discount DECIMAL(10, 2);

    IF @purchase_amount >= 1000
        SET @discount = @purchase_amount * 0.10;
    ELSE IF @purchase_amount >= 500
        SET @discount = @purchase_amount * 0.05;
    ELSE
        SET @discount = 0;
	RETURN @discount;
END;