abstract class ConstructeurLiasseVehicule {
    protected Vehicule Vehicule;

    public Vehicule getVehicule() {
        return vehicule;
    }

    public void createNewVehiculeProduct() {
        vehicule = new Vehicule();
    }

    public abstract void ConstruitBondeCommande ;
    public abstract void ConstruitDemmandeImmatriculation ;

    }

   
  