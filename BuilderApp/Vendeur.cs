class Vendeur{
    private ConstructeurLiasseVehicule constructeurLiasseVehicule;

    public void setConstructeurLiasseVehicule(ConstructeurLiasseVehicule clv) {
        ConstructeurLiasseVehicule = clv;
    }

    public Vehicule getcar() {
        return ConstructeurLiasseVehicule.getVehicule();
    }

    public void constructCar() {
        ConstructeurLiasseVehicule.ConstruitBondeCommande();
        ConstructeurLiasseVehicule.ConstruitDemmandeImmatriculation();
        
    }
}